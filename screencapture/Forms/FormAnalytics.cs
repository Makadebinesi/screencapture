using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screencapture.Forms
{
    public partial class FormAnalytics : Form
    {
        VideoProcessor _videoProcessor;
        TextBox tbProjectDirectory;
        Label labelNameProjectForm1;

        public FormAnalytics(TextBox tbProjectDirectory, Label labelNameProjectForm1)
        {
            InitializeComponent();
            this.tbProjectDirectory = tbProjectDirectory;
            this.labelNameProjectForm1 = labelNameProjectForm1;
        }

        private void FormAnalytics_Load(object sender, EventArgs e)
        {            
            this.labelNameProject.Text = labelNameProjectForm1.Text;
            //загрузка списка исследований
            DirectoryInfo dir = new DirectoryInfo(tbProjectDirectory.Text);
            FileInfo[] files = dir.GetFiles("*.avi");
            foreach (FileInfo f in files)
            {
                lbListVideo.Items.Add(f.ToString().Replace(".avi", ""));
            }
            this.lbListVideo.SetSelected(0, true);
        }

        private void lbListVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNameResearch.Text = lbListVideo.SelectedItem.ToString();
        }

        #region Кластеризация
        private void btnClusterize_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbDifPercent.Text) > 100)
                MessageBox.Show("Вы ввели некорректный процент, введите число от 1 до 100");
            else
            {
                Form1.formPleaseWait.Show();
                this.Enabled = false;

                PointDataSQLite.Clusterize(Path.Combine(tbProjectDirectory.Text, labelNameProject.Text + ".sqlite"), labelNameResearch.Text, Int32.Parse(tbDifPercent.Text));

                this.Enabled = true;
                Form1.formPleaseWait.Hide();
            }
        }

        private void tbDifPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnGazeMarking_Click(object sender, EventArgs e)
        {
            Form1.formPleaseWait.Show();
            this.Enabled = false;

            _videoProcessor = new VideoProcessor();
            _videoProcessor.GazeMarking(Path.Combine(tbProjectDirectory.Text, labelNameResearch.Text) + ".avi", Path.Combine(tbProjectDirectory.Text, labelNameProject.Text + ".sqlite"), labelNameResearch.Text);

            this.Enabled = true;
            Form1.formPleaseWait.Hide();
        }
    }
}
