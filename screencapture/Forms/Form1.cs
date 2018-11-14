using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using screencapture.Forms;
using System.Diagnostics;
using System.Threading;

namespace screencapture
{
    public partial class Form1 : Form
    {
        public VideoRecorder recorder;
        public static IsRecording isRecording = IsRecording.No;
        globalKeyboardHook gkh = new globalKeyboardHook();// hotkeys
        static public FormPleaseWait formPleaseWait = new FormPleaseWait();

        public Form1()
        {
            recorder = new VideoRecorder();
            InitializeComponent();
            this.KeyPreview = true;
        }

        #region Buttons
        private void btnRecStop_Click(object sender, EventArgs e)
        {
            if (isRecording == IsRecording.No)
            {
                if (!String.IsNullOrWhiteSpace(tbProjectDirectory.Text))
                {
                    FormRecordDialog formRecordDialog = new FormRecordDialog(this.tbProjectDirectory, this.recorder, this.btnRecStop, this);
                    formRecordDialog.Show();
                }
                else { MessageBox.Show("ВЫ НЕ ВЫБРАЛИ ПРОЕКТ!"); }
            }
            else
            {
                formPleaseWait.Show();
                this.Enabled = false;
                recorder.EndRecording();
                this.Enabled = true;
                btnRecStop.Text = "Начать исследование";
                isRecording = IsRecording.No;
                tbProjectDirectory_TextChanged(sender, e);
                formPleaseWait.Hide();
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            FormCreateProject formCreateProject = new FormCreateProject(this.tbProjectDirectory);
            formCreateProject.Show();

        }

        private void btnBrowseProject_Click(object sender, EventArgs e)
        {
            FormListOfProjects formListOfProject = new FormListOfProjects(this.tbProjectDirectory);
            formListOfProject.Show();
        }

        private void btnOpenAnalytics_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbProjectDirectory.Text))
            {
                MessageBox.Show("НЕ ВЫБРАН ПРОЕКТ!");
            }
            else
            {
                FormAnalytics formAnalytics = new FormAnalytics(this.tbProjectDirectory, this.labelNameProject);
                formAnalytics.ShowDialog();
            }
        }
        #endregion

        #region TextBoxes and others
        /// <summary>
        /// tbProjectDirectory ключевой textBox, отображает какой проект "выбран"
        /// к его содержимому обращаются методы, чтобы определить куда сохранять файлы
        /// </summary>        
        private void tbProjectDirectory_TextChanged(object sender, EventArgs e)
        {
            lbListVideo.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(tbProjectDirectory.Text);
            FileInfo[] files = dir.GetFiles("*.avi");
            foreach (FileInfo f in files)
            {
                lbListVideo.Items.Add(f.ToString().Replace(".avi", ""));
            }
            labelNameProject.Text = dir.Name;
        }

        private void tbProjectDirectory_DoubleClick(object sender, EventArgs e)
        {
            Process Proc = new Process();
            Proc.StartInfo.FileName = tbProjectDirectory.Text;

            Proc.Start();
            Proc.Close();
        }

        private void lbListVideo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process load = new Process();
                load.StartInfo.FileName = Path.Combine(tbProjectDirectory.Text, lbListVideo.SelectedItem.ToString() + ".avi");
                load.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbListVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = Path.Combine(tbProjectDirectory.Text, lbListVideo.SelectedItem.ToString() + ".txt");
            try
            {
                tbDescription.LoadFile(p, RichTextBoxStreamType.UnicodePlainText);
            }
            catch
            {
                tbDescription.Text = "Описание не найдено";
            }
        }

        #endregion

        #region MenuStrip
        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdCreateProject = new SaveFileDialog();
            sfdCreateProject.InitialDirectory = ConfigurationManager.AppSettings["Default_Project_Directory"];
            sfdCreateProject.RestoreDirectory = true;
            if (sfdCreateProject.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(sfdCreateProject.FileName);
                tbProjectDirectory.Text = sfdCreateProject.FileName;
            }
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdBrowseProject = new FolderBrowserDialog();
            fbdBrowseProject.SelectedPath = ConfigurationManager.AppSettings["Default_Project_Directory"];
            if (fbdBrowseProject.ShowDialog() == DialogResult.OK)
            {
                tbProjectDirectory.Text = fbdBrowseProject.SelectedPath;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting FormSetting = new FormSetting(recorder);
            FormSetting.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }
        #endregion

        #region FormLoad and hotkeys
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "project");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            gkh.HookedKeys.Add(Keys.F2);
            gkh.KeyDown += new KeyEventHandler(btnRecStop_KeyDown);
        }

        private void btnRecStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRecStop.PerformClick();
            }
        }


        #endregion

    }
}
