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
using System.Web;

namespace screencapture.Forms
{
    public partial class FormCreateProject : Form
    {
        private TextBox tbForm1_projectDirectory;
        private ResearchType researchType = 0;

        private string pathToResearchObject;
        public static readonly string researchObjectCatalog = "ResearchObject";// название папки для объекта исследования

        public FormCreateProject(TextBox projectDirectory)
        {
            this.tbForm1_projectDirectory = projectDirectory;
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            string projectName = tbProjectName.Text;
            if (!String.IsNullOrWhiteSpace(projectName))
            {
                string pathToNewProject = Path.Combine(ConfigurationManager.AppSettings["Default_Project_Directory"], projectName);
                string pathToResearchObjectDirectory = Path.Combine(pathToNewProject, researchObjectCatalog);
                string extension = Path.GetExtension(pathToResearchObject);

                Directory.CreateDirectory(pathToNewProject);
                Directory.CreateDirectory(pathToResearchObjectDirectory);

                switch (researchType)
                {
                    case ResearchType.NoType:
                        break;
                    case ResearchType.LocalFile:
                        CreateProjectWithLocalFile(pathToResearchObjectDirectory, extension);
                        break;
                    case ResearchType.Website:
                        CreateProjectWithWebSite(pathToResearchObjectDirectory);
                        break;
                    default:
                        break;
                }


                tbForm1_projectDirectory.Text = pathToNewProject;
                this.Close();
            }
            else
            { MessageBox.Show("Вы не ввели имя проекта!"); }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "rbTypeWebsite":
                        researchType = ResearchType.Website;
                        break;
                    case "rbTypeLocalFile":
                        researchType = ResearchType.LocalFile;
                        break;
                    case "rbNoType":
                        researchType = ResearchType.NoType;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelectFile = new OpenFileDialog();
            pathToResearchObject = tbFileDirectory.Text = ofdSelectFile.ShowDialog() == DialogResult.OK ? ofdSelectFile.FileName : null;
        }

        private void CreateProjectWithLocalFile(string pathToResearchObjectDirectory, string extension)
        {
            string pathToNewFile = Path.Combine(pathToResearchObjectDirectory, researchObjectCatalog + extension);

            if (!File.Exists(pathToNewFile))
                File.Copy(pathToResearchObject, pathToNewFile);
        }

        private void CreateProjectWithWebSite(string pathToResearchObjectDirectory)
        {
            Uri uri;
            if (!Uri.TryCreate(tbWebRef.Text, UriKind.Absolute, out uri))
            {
                MessageBox.Show("Вы неправильно ввели URL-адресс");
            }
            else
            {
                UriBuilder ub = new UriBuilder(tbWebRef.Text);
                string nameUri = ub.Host;
                using (StreamWriter sw = new StreamWriter(Path.Combine(pathToResearchObjectDirectory, nameUri + ".url"), false, Encoding.ASCII))
                    sw.WriteLine("[InternetShortcut]\nURL=" + tbWebRef.Text);
            }
        }
    }
}
