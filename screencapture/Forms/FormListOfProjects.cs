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
using System.Configuration;

namespace screencapture
{
    public partial class FormListOfProjects : Form
    {
        private string selectedProject;
        private TextBox tbDirectoryProject;

        public FormListOfProjects(TextBox tbDirectoryProject)
        {
            InitializeComponent();
            this.tbDirectoryProject = tbDirectoryProject;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            tbDirectoryProject.Text = Path.Combine(ConfigurationManager.AppSettings["Default_Project_Directory"], selectedProject);
            this.Close();
        }

        private void FormListOfProject_Load(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(ConfigurationManager.AppSettings["Default_Project_Directory"]);
            foreach (var dir in directories)
            {
                int i = dir.LastIndexOf(@"\") + 1;
                string nameProject = dir.Substring(i);
                lbListProjects.Items.Add(nameProject);
            }
        }

        private void lbListProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = lbListProjects.SelectedItem.ToString();
        }

        private void lbListProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbDirectoryProject.Text = Path.Combine(ConfigurationManager.AppSettings["Default_Project_Directory"], selectedProject);
            this.Close();          
        }
    }
}
