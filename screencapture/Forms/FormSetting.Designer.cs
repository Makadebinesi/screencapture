namespace screencapture
{
    partial class FormSetting
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
            this.btnSetDefaultDirectory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.tbPathToDefaultDir = new System.Windows.Forms.TextBox();
            this.trackBarSizeMarkerGaze = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGMdiametr = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxTimeGaze = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeMarkerGaze)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetDefaultDirectory
            // 
            this.btnSetDefaultDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetDefaultDirectory.Location = new System.Drawing.Point(116, 60);
            this.btnSetDefaultDirectory.Name = "btnSetDefaultDirectory";
            this.btnSetDefaultDirectory.Size = new System.Drawing.Size(143, 29);
            this.btnSetDefaultDirectory.TabIndex = 0;
            this.btnSetDefaultDirectory.Text = "По умолчанию";
            this.btnSetDefaultDirectory.UseVisualStyleBackColor = true;
            this.btnSetDefaultDirectory.Click += new System.EventHandler(this.btnSetDefaultDirectory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectDirectory);
            this.groupBox1.Controls.Add(this.tbPathToDefaultDir);
            this.groupBox1.Controls.Add(this.btnSetDefaultDirectory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Директория для проектов:";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectDirectory.Location = new System.Drawing.Point(6, 59);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(104, 30);
            this.btnSelectDirectory.TabIndex = 3;
            this.btnSelectDirectory.Text = "Выбрать";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // tbPathToDefaultDir
            // 
            this.tbPathToDefaultDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPathToDefaultDir.Location = new System.Drawing.Point(6, 25);
            this.tbPathToDefaultDir.Name = "tbPathToDefaultDir";
            this.tbPathToDefaultDir.Size = new System.Drawing.Size(481, 26);
            this.tbPathToDefaultDir.TabIndex = 2;
            // 
            // trackBarSizeMarkerGaze
            // 
            this.trackBarSizeMarkerGaze.Location = new System.Drawing.Point(6, 40);
            this.trackBarSizeMarkerGaze.Maximum = 100;
            this.trackBarSizeMarkerGaze.Minimum = 10;
            this.trackBarSizeMarkerGaze.Name = "trackBarSizeMarkerGaze";
            this.trackBarSizeMarkerGaze.Size = new System.Drawing.Size(184, 45);
            this.trackBarSizeMarkerGaze.TabIndex = 2;
            this.trackBarSizeMarkerGaze.Value = 10;
            this.trackBarSizeMarkerGaze.Scroll += new System.EventHandler(this.trackBarSizeMarkerGaze_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGMdiametr);
            this.groupBox2.Controls.Add(this.trackBarSizeMarkerGaze);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Маркер взгляда";
            // 
            // labelGMdiametr
            // 
            this.labelGMdiametr.AutoSize = true;
            this.labelGMdiametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGMdiametr.Location = new System.Drawing.Point(61, 88);
            this.labelGMdiametr.Name = "labelGMdiametr";
            this.labelGMdiametr.Size = new System.Drawing.Size(60, 24);
            this.labelGMdiametr.TabIndex = 3;
            this.labelGMdiametr.Text = "label1";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(400, 412);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(101, 28);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Сохранить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(12, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Настройки обработки:";
            // 
            // tbMaxTimeGaze
            // 
            this.tbMaxTimeGaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxTimeGaze.Location = new System.Drawing.Point(397, 25);
            this.tbMaxTimeGaze.Name = "tbMaxTimeGaze";
            this.tbMaxTimeGaze.Size = new System.Drawing.Size(49, 26);
            this.tbMaxTimeGaze.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbMaxTimeGaze);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Максимальное время фиксации взгляда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 64);
            this.label2.TabIndex = 8;
            this.label2.Text = "Необходимо для цветовой дифференциации \r\nмаркера взгляда: 0-20% - Синий, 20-40% -" +
    " Голубой,\r\n 40-60% - Зеленый, 60-80% - Желтый, \r\n80-100% - Оранжевый, 100%+ - Кр" +
    "асный ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(446, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сек.";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeMarkerGaze)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetDefaultDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPathToDefaultDir;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.TrackBar trackBarSizeMarkerGaze;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelGMdiametr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxTimeGaze;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}