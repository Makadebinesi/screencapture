using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screencapture
{
    class VideoProcessor
    {
        private string pathToFile;
        private string tableName;
        private bool writing = false;
        private bool isRecording = true;

        private VideoFileReader reader;
        private VideoFileWriter writer;

        private Dictionary<int, Pen> pen = new Dictionary<int, Pen>
        {
            { 100, new  Pen(Color.FromArgb(255, 0, 0), 5) },
            { 80, new Pen(Color.FromArgb(255, 170, 0), 5) },
            { 60, new Pen(Color.FromArgb(255, 255, 0), 5) },
            { 40, new Pen(Color.FromArgb(115, 255, 0), 5) },
            { 20, new Pen(Color.FromArgb(0, 190, 255), 5) },
            { 0, new Pen(Color.FromArgb(0, 0, 255), 5) }
        };

        Font font;
        Brush brush_Red;
        Brush brush_Blue;

        private SQLiteCommand _SQLiteCommand;
        private SQLiteConnection _SQLiteConnetion;

        private int frameID;
        private double TGF;//timeGazeFixed
        private int gazeX;
        private int gazeY;
        private int gazeMarkerSize;
        private double maxTimeFixation;

        private int meditationPerc;
        private int attentionPerc;

        #region Отрисовка маркера
        public void GazeMarking(string pathToFile, string pathToBD, string tableName)
        {
            this.tableName = tableName;

            font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);

            brush_Red = new SolidBrush(Color.Red);
            brush_Blue = new SolidBrush(Color.Blue);

            maxTimeFixation = Double.Parse(ConfigurationManager.AppSettings["Max_Time_Fixation"]);
            frameID = 1;
            gazeMarkerSize = Convert.ToInt32(ConfigurationManager.AppSettings["Size_Gaze_Marker"]);
            reader = new VideoFileReader();
            writer = new VideoFileWriter();
            _SQLiteCommand = new SQLiteCommand();
            _SQLiteConnetion = new SQLiteConnection(@"Data Source=" + pathToBD);
            _SQLiteCommand.Connection = _SQLiteConnetion;

            _SQLiteConnetion.Open();
            reader.Open(pathToFile);
            writer.Open(pathToFile.Replace(".avi", "MARKERED.avi"), reader.Width, reader.Height, 25, VideoCodec.MPEG4);

            long frameCount = reader.FrameCount;
            for (int i = 0; i < frameCount; i++)
            {
                ProcessFrame();
            }
            reader.Close();
            writer.Close();
        }

        private void ProcessFrame()
        {
            //Получаем данные о текущем кадре из БД    
            _SQLiteCommand.CommandText = "SELECT timeGazeFixed FROM " + tableName + " WHERE id=" + frameID;
            TGF = Double.Parse(_SQLiteCommand.ExecuteScalar().ToString());
            _SQLiteCommand.CommandText = "SELECT gazeX FROM " + tableName + " WHERE id=" + frameID;
            gazeX = Int32.Parse(_SQLiteCommand.ExecuteScalar().ToString());
            _SQLiteCommand.CommandText = "SELECT gazeY FROM " + tableName + " WHERE id=" + frameID;
            gazeY = Int32.Parse(_SQLiteCommand.ExecuteScalar().ToString());
            _SQLiteCommand.CommandText = "SELECT meditation FROM " + tableName + " WHERE id=" + frameID;
            meditationPerc = Int32.Parse(_SQLiteCommand.ExecuteScalar().ToString());
            _SQLiteCommand.CommandText = "SELECT attention FROM " + tableName + " WHERE id=" + frameID;
            attentionPerc = Int32.Parse(_SQLiteCommand.ExecuteScalar().ToString());

            frameID++;//для получения данных о следующем кадре
            int perc = (int)(TGF / maxTimeFixation) * 100;//процент от максимального времени фиксации взгляда, макс время устанавливает пользователь в настройках

            Bitmap frameImage = reader.ReadVideoFrame();//получаем изображение кадра
            using (Graphics g = Graphics.FromImage(frameImage))
            {
                for (int i = 100; i >= 0; i -= 20)
                {
                    if (perc >= i)
                    {
                        try
                        {
                            g.DrawEllipse(pen[i], gazeX - (gazeMarkerSize / 2), gazeY - (gazeMarkerSize / 2), gazeMarkerSize, gazeMarkerSize);
                        }
                        catch { }
                        //g.DrawString("Расслабленость " + meditationPerc + " %", font, brush_Purple, 30, 50);
                        //g.DrawString("Внимание " + attentionPerc + " %", font, brush_Orange, 30, 100);
                        g.DrawRectangle(new Pen(brush_Red), 30, 700, 30, 300);
                        g.DrawRectangle(new Pen(brush_Blue), 70, 700, 30, 300);
                        g.FillRectangle(brush_Red, 30, 700 + (300 - attentionPerc * 3), 30, (attentionPerc * 3));
                        g.FillRectangle(brush_Blue, 70, 700 + (300 - meditationPerc * 3), 30, (meditationPerc * 3));
                        break;
                    }
                }
            }

            if (isRecording && !writing)
            {
                writing = true;
                writer.WriteVideoFrame(frameImage);
                writing = false;
            }
            frameImage.Dispose();
        }
        #endregion
    }
}

