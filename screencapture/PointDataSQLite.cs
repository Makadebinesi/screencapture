using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SQLite.Linq;
using System.Threading;
using System.Drawing;

namespace screencapture
{

    public class PointDataSQLite
    {
        SQLiteConnection _SQLiteConnetion;
        SQLiteCommand _SQLiteCommand;
        string tableName;
        public List<FramePoint> ListPointsData;

        /// <summary>
        /// Создает таблицу для нового исследования в имеющейся или новой БД
        /// </summary>
        /// <param name="pathToDB">Полный путь с расширением</param>
        /// <param name="tableName">Имя таблицы\исследования</param>
        public void CreateOrUsingDB(string pathToDB, string tableName)
        {
            this.tableName = tableName;

            if (!File.Exists(pathToDB))
                SQLiteConnection.CreateFile(pathToDB);

            try
            {
                _SQLiteCommand = new SQLiteCommand();
                _SQLiteConnetion = new SQLiteConnection("Data Source=" + pathToDB);
                _SQLiteConnetion.Open();
                _SQLiteCommand.Connection = _SQLiteConnetion;
                _SQLiteCommand.CommandText = "CREATE TABLE IF NOT EXISTS " + tableName + " (id INTEGER PRIMARY KEY AUTOINCREMENT, gazeX INTEGER, gazeY INTEGER, mouseX INTEGER, mouseY INTEGER, timeStamp DOUBLE, timeGazeFixed DOUBLE, cluster INTEGER, meditation INTEGER, attention INTEGER)";
                _SQLiteCommand.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Disconnected, Ошибка:{0}", ex.Message);
            }
        }

        /// <summary>
        /// Записывает имеющийся List с данными в таблицу базы данных.
        /// </summary>
        public void SerializeToBD()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;//Для запись в бд типов с плавающей точкой(а не запятой)
            lock (ListPointsData)
            {
                foreach (var point in ListPointsData)
                {
                    _SQLiteCommand.CommandText = "INSERT INTO " + tableName + " ( gazeX, gazeY, mouseX, mouseY, timeStamp, timeGazeFixed, cluster ) "
                        + "VALUES('" + point.X + "', '" + point.Y + "', '" + point.mouseX + "', '" + point.mouseY + "', '" + point.timeStamp + "', '" + point.timeGazeFixed + "', '" + point.cluster + "'); ";
                    _SQLiteCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Пишет каждый кадр сразу в базу данных
        /// </summary>
        /// <param name="tempGazeX">Абсцисса положения взгляда</param>
        /// <param name="tempGazeY">Ордината положения взгляда</param>
        /// <param name="mouseCursorX">Абсцисса положения курсора мыши</param>
        /// <param name="mouseCursorY">Ордината положения курсора мыши</param>
        /// <param name="timeCounter">Текущее время в сек, относительно начала записи</param>
        public void WritingToDB(double GazeX, double GazeY, double mouseCursorX, double mouseCursorY, double timeCounter, int meditationPerc, int attentionPerc)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            _SQLiteCommand.CommandText = "INSERT INTO " + tableName + " ( gazeX, gazeY, mouseX, mouseY, timeStamp, timeGazeFixed, cluster, meditation, attention ) "
                        + "VALUES('" + (int)GazeX + "', '" + (int)GazeY + "', '" + (int)mouseCursorX + "', '" + (int)mouseCursorY + "', '" + timeCounter + "', '" + 0 + "', '" + 0 + "', '" + meditationPerc + "', '" + attentionPerc + "'); ";
            _SQLiteCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Вызывается при записи кадра, добавляет в List новый элемент с координатами и временем записи кадра относительно начала записи.
        /// </summary>
        /// <param name="tempGazeX">Абсцисса положения взгляда</param>
        /// <param name="tempGazeY">Ордината положения взгляда</param>
        /// <param name="mouseCursorX">Абсцисса положения курсора мыши</param>
        /// <param name="mouseCursorY">Ордината положения курсора мыши</param>
        /// <param name="timeCounter">Текущее время в сек, относительно начала записи</param>
        public void LogWriting(double tempGazeX, double tempGazeY, double mouseCursorX, double mouseCursorY, double timeCounter)
        {
            lock (ListPointsData)
            {
                this.ListPointsData.Add(new FramePoint((int)tempGazeX, (int)tempGazeY, (int)mouseCursorX, (int)mouseCursorY, timeCounter));
            }
        }

        /// <summary>
        /// Разделяет записи на кластеры, определяя когда "фиксировался" взгляд, заполняет в нужной таблице
        /// </summary>
        /// <param name="pathToDB">Путь к базе данных, где содержится таблица с координатами взгляда gazeX и gazeY, и столбцами timeGazeFixed и cluster</param>
        /// <param name="tableName">Имя таблицы соответствующей видеозаписи исследования, с заполнеными координатами взгляда на каждый кадр видеозаписи</param>
        /// <param name="dif">Максимльное растояние между первой точкой в кластере и всеми остальными / разброс кластера(скопления точек)</param>
        public static void Clusterize(string pathToDB, string tableName, int difPercent)
        {
            //Warning! От прочтения дальнейшего кода, может стать очень грустно.           
            int dif = (Screen.PrimaryScreen.Bounds.Height / 100) * difPercent; //находим заданый процент от высоты экрана в пикселях

            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            SQLiteConnection _SQLiteConnetion = new SQLiteConnection("Data Source=" + pathToDB);
            SQLiteCommand _SQLiteCommand = new SQLiteCommand();
            _SQLiteCommand.Connection = _SQLiteConnetion;
            _SQLiteConnetion.Open();

            _SQLiteCommand.CommandText = "SELECT * FROM " + tableName;
            SQLiteDataReader reader = _SQLiteCommand.ExecuteReader();

            List<RowCluster> points = new List<RowCluster>();
            List<ClusterTimeFixation> clusters = new List<ClusterTimeFixation>();

            int StartX = 0;//Координаты первой точки в кластере
            int StartY = 0;
            int ClusterCounter = 1;//Счетчик кластеров, когда по условию создается новый кластер, увеличивается
            double startTimeFixed = 0;//Меняется, когда объявляется новый кластер и указывает на время начала фиксации в номо кластере
            double timeFixed = 0;//Вычисляется на каждой строке, время фиксирования от начала фиксации на кластере до данной точки
            double tempTimeStamp = 0;//для хранения значения timeStamp предыдущей точки, при последовательном проходе по ним
            //Читает каждую строку по порядку
            while (reader.Read())
            {
                //Первую строку определяем как стартовую для кластера 1, по идее это условие срабатывает только 1 раз вначале
                if (StartX == 0 && StartY == 0)
                {
                    StartX = Int32.Parse(reader["gazeX"].ToString());
                    StartY = Int32.Parse(reader["gazeY"].ToString());
                }
                //Вычитаем из XY текущей строки значения XY стартовой точки последнего кластера, 
                //если разница не больше, чем заданый пользователем предел, то добавляем в List<UpdateRow> id этой строки с номером текущего кластера...                
                if ((Math.Abs((Int32.Parse(reader["gazeX"].ToString()) - StartX)) <= dif) && (Math.Abs((Int32.Parse(reader["gazeY"].ToString()) - StartY)) <= dif))
                {
                    points.Add(new RowCluster(Int32.Parse(reader["id"].ToString()), ClusterCounter));//добавляется новая точка в list, с номером текущего кластера
                    timeFixed = Double.Parse(reader["timeStamp"].ToString()) - startTimeFixed;
                    tempTimeStamp = Double.Parse(reader["timeStamp"].ToString());//временная переменная хранит таймстамп предыдущего шага
                }
                else//... иначе номер кластера увеличиваем на единицу и данная точка становится стартовой для нового кластера
                {
                    clusters.Add(new ClusterTimeFixation(ClusterCounter, timeFixed));//кластер записывается в list
                    ClusterCounter++;//начинается новый кластер, абстрактно
                    points.Add(new RowCluster(Int32.Parse(reader["id"].ToString()), ClusterCounter));//добавляется новая точка в list, с номером  нового кластера
                    StartX = Int32.Parse(reader["gazeX"].ToString());//определяются стартовые точки, как начальная точка нового кластера
                    StartY = Int32.Parse(reader["gazeY"].ToString());

                    startTimeFixed = tempTimeStamp;//Время начала фиксации нового кластера
                    tempTimeStamp = Double.Parse(reader["timeStamp"].ToString());//временная переменная для сохранения таймстампа этого шага для следующей строки
                }
            }
            clusters.Add(new ClusterTimeFixation(ClusterCounter, timeFixed));//добавляется последний кластер
            reader.Close();

            //Делаем апдейт в БД, для добавления номеров кластеров на каждой строке
            foreach (var i in points)
            {
                _SQLiteCommand.CommandText = "UPDATE " + tableName + " SET cluster=" + i.cluster + " WHERE id=" + i.id;
                _SQLiteCommand.ExecuteNonQuery();
            }
            //Соотносим каждую строку(точку) кластеру из списка кластеров и апдейтим время фиксации в каждой точке на время фиксации кластера
            foreach (var i in points)
            {
                foreach (var j in clusters)
                {
                    if (i.cluster == j.cluster)
                    {
                        _SQLiteCommand.CommandText = "UPDATE " + tableName + " SET timeGazeFixed=" + j.timeFixation + " WHERE id=" + i.id;
                        _SQLiteCommand.ExecuteNonQuery();
                    }
                }
            }
            _SQLiteConnetion.Close();
        }

    }

    /// <summary>
    /// Вспомогательная Структура содержащая информацию о том, какой точке соответствует какой кластер
    /// </summary>
    struct RowCluster
    {
        public int id { get; set; }
        public int cluster { get; set; }

        public RowCluster(int id, int cluster)
        {
            this.id = id;
            this.cluster = cluster;
        }
    }

    /// <summary>
    /// Вспомогательная Структура представляющая кластер со временем фиксации взгляда на нем
    /// </summary>
    struct ClusterTimeFixation
    {
        public int cluster { get; set; }
        public double timeFixation { get; set; }

        public ClusterTimeFixation(int cluster, double timeFixation)
        {
            this.cluster = cluster;
            this.timeFixation = timeFixation;
        }
    }
}
