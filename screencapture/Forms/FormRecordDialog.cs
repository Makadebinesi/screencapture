using screencapture.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screencapture
{
    public partial class FormRecordDialog : Form
    {
        VideoRecorder recorder;
        TextBox tbProjectDirectory;
        Button btnRecStop;
        Form form1;

        public FormRecordDialog(TextBox tbProjectDirectory, VideoRecorder recorder, Button btnRecStop, Form form1)
        {
            this.btnRecStop = btnRecStop;
            this.recorder = recorder;
            this.tbProjectDirectory = tbProjectDirectory;
            this.form1 = form1;
            InitializeComponent();
        }

        private void btnStartRec_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(tbProjectDirectory.Text, tbName.Text + ".avi")))
            {
                if (cbOpenResearchObject.CheckState == CheckState.Checked)
                {

                    string[] files = Directory.GetFiles(Path.Combine(tbProjectDirectory.Text, FormCreateProject.researchObjectCatalog));
                    try
                    {
                        Process.Start(files[0]);
                    }
                    catch
                    { }
                }

                btnRecStop.Text = "СТОП";
                //начинает запись
                recorder.StartRecording(tbProjectDirectory.Text, Path.Combine(tbProjectDirectory.Text, tbName.Text), tbName.Text, tbDescription.Text);

                this.Close();
                form1.WindowState = FormWindowState.Minimized;
            }
            else { MessageBox.Show("Файл с таким именем уже существует!"); }
            Form1.isRecording = IsRecording.Yes;
        }

        private void btnCancelRD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRecordDialog_Load(object sender, EventArgs e)
        {
            //TODO: автоматическое добавлениие к имени по умолчанию числа 
            //в формате {##} 01, 02... если уже существует файл с таким же именем
            string examinee = "examinee";
            tbName.Text = examinee;
        }
    }
}
