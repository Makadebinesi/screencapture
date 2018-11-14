namespace screencapture
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecStop = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.tbProjectDirectory = new System.Windows.Forms.TextBox();
            this.labelSelectedProject = new System.Windows.Forms.Label();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.lbListVideo = new System.Windows.Forms.ListBox();
            this.labelNameProject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDirectoryProject = new System.Windows.Forms.Label();
            this.groupBoxQuickMenu = new System.Windows.Forms.GroupBox();
            this.btnOpenAnalytics = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxQuickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecStop
            // 
            this.btnRecStop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRecStop.Location = new System.Drawing.Point(401, 92);
            this.btnRecStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecStop.Name = "btnRecStop";
            this.btnRecStop.Size = new System.Drawing.Size(147, 51);
            this.btnRecStop.TabIndex = 0;
            this.btnRecStop.Text = "Начать исследование";
            this.btnRecStop.UseVisualStyleBackColor = true;
            this.btnRecStop.Click += new System.EventHandler(this.btnRecStop_Click);
            this.btnRecStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRecStop_KeyDown);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProject.Location = new System.Drawing.Point(6, 19);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(127, 25);
            this.btnCreateProject.TabIndex = 1;
            this.btnCreateProject.Text = "Создать проект";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // tbProjectDirectory
            // 
            this.tbProjectDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectDirectory.Location = new System.Drawing.Point(11, 153);
            this.tbProjectDirectory.Name = "tbProjectDirectory";
            this.tbProjectDirectory.ReadOnly = true;
            this.tbProjectDirectory.Size = new System.Drawing.Size(536, 22);
            this.tbProjectDirectory.TabIndex = 2;
            this.tbProjectDirectory.TextChanged += new System.EventHandler(this.tbProjectDirectory_TextChanged);
            this.tbProjectDirectory.DoubleClick += new System.EventHandler(this.tbProjectDirectory_DoubleClick);
            // 
            // labelSelectedProject
            // 
            this.labelSelectedProject.AutoSize = true;
            this.labelSelectedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedProject.Location = new System.Drawing.Point(8, 100);
            this.labelSelectedProject.Name = "labelSelectedProject";
            this.labelSelectedProject.Size = new System.Drawing.Size(174, 20);
            this.labelSelectedProject.TabIndex = 3;
            this.labelSelectedProject.Text = "Выбранный проект:";
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseProject.Location = new System.Drawing.Point(139, 19);
            this.btnBrowseProject.Name = "btnBrowseProject";
            this.btnBrowseProject.Size = new System.Drawing.Size(127, 25);
            this.btnBrowseProject.TabIndex = 4;
            this.btnBrowseProject.Text = "Выбрать проект";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click += new System.EventHandler(this.btnBrowseProject_Click);
            // 
            // lbListVideo
            // 
            this.lbListVideo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListVideo.FormattingEnabled = true;
            this.lbListVideo.ItemHeight = 19;
            this.lbListVideo.Location = new System.Drawing.Point(12, 217);
            this.lbListVideo.Name = "lbListVideo";
            this.lbListVideo.Size = new System.Drawing.Size(205, 175);
            this.lbListVideo.TabIndex = 5;
            this.lbListVideo.SelectedIndexChanged += new System.EventHandler(this.lbListVideo_SelectedIndexChanged);
            this.lbListVideo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbListVideo_MouseDoubleClick);
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProject.Location = new System.Drawing.Point(188, 100);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(137, 20);
            this.labelNameProject.TabIndex = 6;
            this.labelNameProject.Text = "<Имя проекта>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.createProjectToolStripMenuItem.Text = "Создать проект";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openProjectToolStripMenuItem.Text = "Открыть проект";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.settingToolStripMenuItem.Text = "Настройки";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.HelpToolStripMenuItem.Text = "Справка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // labelDirectoryProject
            // 
            this.labelDirectoryProject.AutoSize = true;
            this.labelDirectoryProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirectoryProject.Location = new System.Drawing.Point(13, 129);
            this.labelDirectoryProject.Name = "labelDirectoryProject";
            this.labelDirectoryProject.Size = new System.Drawing.Size(146, 16);
            this.labelDirectoryProject.TabIndex = 8;
            this.labelDirectoryProject.Text = "Директория проекта:";
            // 
            // groupBoxQuickMenu
            // 
            this.groupBoxQuickMenu.Controls.Add(this.btnOpenAnalytics);
            this.groupBoxQuickMenu.Controls.Add(this.btnBrowseProject);
            this.groupBoxQuickMenu.Controls.Add(this.btnCreateProject);
            this.groupBoxQuickMenu.Location = new System.Drawing.Point(12, 28);
            this.groupBoxQuickMenu.Name = "groupBoxQuickMenu";
            this.groupBoxQuickMenu.Size = new System.Drawing.Size(536, 58);
            this.groupBoxQuickMenu.TabIndex = 9;
            this.groupBoxQuickMenu.TabStop = false;
            this.groupBoxQuickMenu.Text = "Меню";
            // 
            // btnOpenAnalytics
            // 
            this.btnOpenAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenAnalytics.Location = new System.Drawing.Point(347, 19);
            this.btnOpenAnalytics.Name = "btnOpenAnalytics";
            this.btnOpenAnalytics.Size = new System.Drawing.Size(183, 25);
            this.btnOpenAnalytics.TabIndex = 5;
            this.btnOpenAnalytics.Text = "Анализ и обработка проекта";
            this.btnOpenAnalytics.UseVisualStyleBackColor = true;
            this.btnOpenAnalytics.Click += new System.EventHandler(this.btnOpenAnalytics_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.Location = new System.Drawing.Point(234, 217);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(314, 175);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Список исследований:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Описание исследования:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.groupBoxQuickMenu);
            this.Controls.Add(this.labelDirectoryProject);
            this.Controls.Add(this.labelNameProject);
            this.Controls.Add(this.lbListVideo);
            this.Controls.Add(this.labelSelectedProject);
            this.Controls.Add(this.tbProjectDirectory);
            this.Controls.Add(this.btnRecStop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(400, 200);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Eye Stream Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxQuickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecStop;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.TextBox tbProjectDirectory;
        private System.Windows.Forms.Label labelSelectedProject;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.ListBox lbListVideo;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Label labelDirectoryProject;
        private System.Windows.Forms.GroupBox groupBoxQuickMenu;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenAnalytics;
    }
}

