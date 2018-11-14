using System;
using System.Collections.Generic;
using System.Text;
using Accord;
using Accord.Video.FFMPEG;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Tobii.Interaction;
using Tobii.Interaction.Framework;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Timer = System.Timers.Timer;
using System.Text.RegularExpressions;
using screencapture.Properties;
using System.Configuration;
using System.Threading.Tasks;

namespace screencapture
{
    public class VideoRecorder
    {
        private VideoFileWriter videoWriter;
        private PointDataSQLite SQLite;
        private EyeTracker eyeTracker;
        private const int intervalBetweenFrames = 32; // 1000 / fps

        private Timer frameTimer;
        DateTime startVideoTime;

        private bool isRecording;
        private bool writing = false;

        string pathToDescription;
        string descriptionText;

        double mouseX, mouseY, tempGazeX, tempGazeY, timer;        
        int gazeMarkerSize;

        private System.Drawing.Size screenSize;
        Pen gazeMarkerpPen = new Pen(Color.FromArgb(0, 124, 173), 5);
        Image cursor = Resources.cursor_yellow;

        /// <summary>
        /// Конструктор
        /// </summary>
        public VideoRecorder()
        {
            eyeTracker = EyeTracker.GetEyeTracker();
            videoWriter = new VideoFileWriter();

            //Получение границ экрана
            System.Drawing.Rectangle bounds = Screen.PrimaryScreen.Bounds;
            screenSize = new System.Drawing.Size(bounds.Width, bounds.Height);

            //Таймер запускающий запись и редактирование кадра с заданой частотой(FrameRate)
            frameTimer = new Timer(intervalBetweenFrames);
            frameTimer.Elapsed += ProcessFrame;
            frameTimer.AutoReset = true;

            isRecording = false;
        }

        /// <summary>
        /// Начинает запись, получая путь к файлу
        /// </summary>
        /// <param name="projectDirectory">Путь к папке с проектом</param>
        /// <param name="pathToFILE">Полное имя видеозаписи</param>
        /// <param name="nameResearch">Имя исследования</param>
        /// <param name="description">Текст описания исследования</param>
        public void StartRecording(string projectDirectory, string pathToFILE, string nameResearch, string description)
        {
            gazeMarkerSize = Convert.ToInt32(ConfigurationManager.AppSettings["Size_Gaze_Marker"]);

            string pathToVIDEO = pathToFILE + ".avi";
            pathToDescription = pathToFILE + ".txt";
            string pathToBD = Path.Combine(projectDirectory, Path.GetFileName(projectDirectory) + ".sqlite");

            this.descriptionText = description;

            //Получение потока координат с айтрекера
            eyeTracker.StartEyeStream();

            //Создание/открытие БД и таблица с логом
            SQLite = new PointDataSQLite();
            //SQLite.ListPointsData = new List<FramePoint>();
            SQLite.CreateOrUsingDB(pathToBD, nameResearch);

            //Старт записи кадров
            isRecording = true;
            videoWriter.Open(pathToVIDEO, screenSize.Width, screenSize.Height, 25, VideoCodec.MPEG4);
            frameTimer.Start();
            startVideoTime = DateTime.Now;
        }

        /// <summary>
        /// Безопастно заканчивает запись, создает лог, описание txt, останавливает поток с айтрекера
        /// </summary>
        public void EndRecording()
        {
            isRecording = false;
            while (writing) { }
            frameTimer.Stop();
            videoWriter.Close();
            eyeTracker.StopEyeStream();

            CreateDescriptionFile(descriptionText, pathToDescription);
            //SQLite.SerializeToBD();
        }

        /// <summary>
        /// Создание описания к видеозаписи в том же каталоге в .txt
        /// </summary>
        private void CreateDescriptionFile(string descriptionText, string pathToDescription)
        {
            StreamWriter description = new StreamWriter(pathToDescription, false, Encoding.Unicode);
            description.Write(descriptionText);
            description.Close();
        }


        /// <summary>
        /// Наложение на кадр маркеров отображающих положение взгляда и курсора и запись кадра
        /// </summary>        
        private void ProcessFrame(object source, System.Timers.ElapsedEventArgs e)
        {
            tempGazeX = eyeTracker.gazeX;
            tempGazeY = eyeTracker.gazeY;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            timer = (DateTime.Now - startVideoTime).TotalSeconds;

            Bitmap frameImage = new Bitmap(screenSize.Width, screenSize.Height);

            using (Graphics g = Graphics.FromImage(frameImage))
            {
                g.CopyFromScreen(0, 0, 0, 0, screenSize, CopyPixelOperation.SourceCopy);
                //g.DrawEllipse(gazeMarkerpPen, (int)eyeTracker.tempGazeX - (gazeMarkerSize / 2), (int)eyeTracker.tempGazeY - (gazeMarkerSize / 2), gazeMarkerSize, gazeMarkerSize);
                //g.DrawImage(cursor, (int)mouseX, (int)mouseY);
            }
            
            if (isRecording && !writing)
            {
                writing = true;
                videoWriter.WriteVideoFrame(frameImage);
                SQLite.WritingToDB(tempGazeX, tempGazeY, mouseX, mouseY, timer);//LogWriting - писать сначало в list, нужно раскоментить выше сериализацию и инициализацию List
                writing = false;
            }                                    
            frameImage.Dispose();
        }

    }
}
