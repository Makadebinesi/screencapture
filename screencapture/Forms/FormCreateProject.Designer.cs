namespace screencapture.Forms
{
    partial class FormCreateProject
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
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoType = new System.Windows.Forms.RadioButton();
            this.tbFileDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.rbTypeLocalFile = new System.Windows.Forms.RadioButton();
            this.tbWebRef = new System.Windows.Forms.TextBox();
            this.rbTypeWebsite = new System.Windows.Forms.RadioButton();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectName.Location = new System.Drawing.Point(17, 38);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(372, 26);
            this.tbProjectName.TabIndex = 0;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProjectName.Location = new System.Drawing.Point(25, 15);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(122, 20);
            this.labelProjectName.TabIndex = 1;
            this.labelProjectName.Text = "Имя проекта:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoType);
            this.groupBox1.Controls.Add(this.tbFileDirectory);
            this.groupBox1.Controls.Add(this.btnBrowseFile);
            this.groupBox1.Controls.Add(this.rbTypeLocalFile);
            this.groupBox1.Controls.Add(this.tbWebRef);
            this.groupBox1.Controls.Add(this.rbTypeWebsite);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип исследования";
            // 
            // rbNoType
            // 
            this.rbNoType.AutoSize = true;
            this.rbNoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNoType.Location = new System.Drawing.Point(7, 185);
            this.rbNoType.Name = "rbNoType";
            this.rbNoType.Size = new System.Drawing.Size(95, 24);
            this.rbNoType.TabIndex = 5;
            this.rbNoType.TabStop = true;
            this.rbNoType.Text = "Без типа";
            this.rbNoType.UseVisualStyleBackColor = true;
            this.rbNoType.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tbFileDirectory
            // 
            this.tbFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileDirectory.Location = new System.Drawing.Point(7, 133);
            this.tbFileDirectory.Name = "tbFileDirectory";
            this.tbFileDirectory.ReadOnly = true;
            this.tbFileDirectory.Size = new System.Drawing.Size(359, 26);
            this.tbFileDirectory.TabIndex = 4;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseFile.Location = new System.Drawing.Point(173, 103);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseFile.TabIndex = 3;
            this.btnBrowseFile.Text = "Выбрать";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // rbTypeLocalFile
            // 
            this.rbTypeLocalFile.AutoSize = true;
            this.rbTypeLocalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTypeLocalFile.Location = new System.Drawing.Point(7, 103);
            this.rbTypeLocalFile.Name = "rbTypeLocalFile";
            this.rbTypeLocalFile.Size = new System.Drawing.Size(160, 24);
            this.rbTypeLocalFile.TabIndex = 2;
            this.rbTypeLocalFile.TabStop = true;
            this.rbTypeLocalFile.Text = "Локальный файл";
            this.rbTypeLocalFile.UseVisualStyleBackColor = true;
            this.rbTypeLocalFile.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tbWebRef
            // 
            this.tbWebRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWebRef.Location = new System.Drawing.Point(7, 56);
            this.tbWebRef.Name = "tbWebRef";
            this.tbWebRef.Size = new System.Drawing.Size(360, 26);
            this.tbWebRef.TabIndex = 1;
            // 
            // rbTypeWebsite
            // 
            this.rbTypeWebsite.AutoSize = true;
            this.rbTypeWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTypeWebsite.Location = new System.Drawing.Point(6, 26);
            this.rbTypeWebsite.Name = "rbTypeWebsite";
            this.rbTypeWebsite.Size = new System.Drawing.Size(281, 24);
            this.rbTypeWebsite.TabIndex = 0;
            this.rbTypeWebsite.TabStop = true;
            this.rbTypeWebsite.Text = "Website (скопируйте URL-адресс)";
            this.rbTypeWebsite.UseVisualStyleBackColor = true;
            this.rbTypeWebsite.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProject.Location = new System.Drawing.Point(17, 299);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(130, 28);
            this.btnCreateProject.TabIndex = 3;
            this.btnCreateProject.Text = "Создать";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(259, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.tbProjectName);
            this.Name = "FormCreateProject";
            this.Text = "Новый проект";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTypeWebsite;
        private System.Windows.Forms.RadioButton rbTypeLocalFile;
        private System.Windows.Forms.TextBox tbWebRef;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox tbFileDirectory;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbNoType;
    }
}