using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace screencapture
{
    public partial class FormSetting : Form
    {
        Pen gazeMarkerpPen = new Pen(Color.FromArgb(0, 124, 173), 5);
        int gazeMarkerSize = Convert.ToInt32(ConfigurationManager.AppSettings["Size_Gaze_Marker"]);

        VideoRecorder recoder;
        int size;

        public FormSetting(VideoRecorder recoder)
        {
            this.recoder = recoder;
            InitializeComponent();
        }

        #region Настройка директории для проектов
        private void btnSetDefaultDirectory_Click(object sender, EventArgs e)
        {
            tbPathToDefaultDir.Text = Path.Combine(Directory.GetCurrentDirectory(), "project");
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBDdir = new FolderBrowserDialog();
            FBDdir.SelectedPath = ConfigurationManager.AppSettings["Default_Project_Directory"];
            if (FBDdir.ShowDialog() == DialogResult.OK)
            {
                tbPathToDefaultDir.Text = FBDdir.SelectedPath;
            }
        }
        #endregion


        #region Настройка маркера взгляда на обработаном видео           
        private void trackBarSizeMarkerGaze_Scroll(object sender, EventArgs e)
        {
            size = trackBarSizeMarkerGaze.Value;
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(Color.FromName("Control"));
                g.DrawEllipse(gazeMarkerpPen, 370 - (size / 2), 200 - (size / 2), size, size);
            }
            labelGMdiametr.Text = trackBarSizeMarkerGaze.Value.ToString() + " px";
        }
        #endregion

        #region Стартовые параметры, принять\отменить
        private void FormSetting_Load(object sender, EventArgs e)
        {
            //Инициализация имеющихся настроек из app.config
            tbPathToDefaultDir.Text = ConfigurationManager.AppSettings["Default_Project_Directory"];
            trackBarSizeMarkerGaze.Value = Int32.Parse(ConfigurationManager.AppSettings["Size_Gaze_Marker"]);
            tbMaxTimeGaze.Text = ConfigurationManager.AppSettings["Max_Time_Fixation"];
            labelGMdiametr.Text = trackBarSizeMarkerGaze.Value.ToString() + " px";            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Изменение насроек в app.config
            Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            currentConfig.AppSettings.Settings["Size_Gaze_Marker"].Value = trackBarSizeMarkerGaze.Value.ToString();
            currentConfig.AppSettings.Settings["Default_Project_Directory"].Value = tbPathToDefaultDir.Text;
            currentConfig.AppSettings.Settings["Max_Time_Fixation"].Value = tbMaxTimeGaze.Text;
            currentConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }
        #endregion
    }
}
