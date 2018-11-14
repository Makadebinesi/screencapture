namespace screencapture.Forms
{
    partial class FormAnalytics
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNameProject = new System.Windows.Forms.Label();
            this.btnClusterize = new System.Windows.Forms.Button();
            this.labelStateAnalytics = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbListVideo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNameResearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDifPercent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGazeMarking = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обработка  проекта : ";
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProject.Location = new System.Drawing.Point(189, 13);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(137, 20);
            this.labelNameProject.TabIndex = 1;
            this.labelNameProject.Text = "<Имя проекта>";
            // 
            // btnClusterize
            // 
            this.btnClusterize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClusterize.Location = new System.Drawing.Point(294, 22);
            this.btnClusterize.Name = "btnClusterize";
            this.btnClusterize.Size = new System.Drawing.Size(137, 29);
            this.btnClusterize.TabIndex = 2;
            this.btnClusterize.Text = "Применть";
            this.btnClusterize.UseVisualStyleBackColor = true;
            this.btnClusterize.Click += new System.EventHandler(this.btnClusterize_Click);
            // 
            // labelStateAnalytics
            // 
            this.labelStateAnalytics.AutoSize = true;
            this.labelStateAnalytics.Location = new System.Drawing.Point(13, 293);
            this.labelStateAnalytics.Name = "labelStateAnalytics";
            this.labelStateAnalytics.Size = new System.Drawing.Size(0, 13);
            this.labelStateAnalytics.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кластеризация - выделение областей фиксации \r\nвзгляда и запись в базу данных прое" +
    "кта.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(495, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Список исследований:";
            // 
            // lbListVideo
            // 
            this.lbListVideo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListVideo.FormattingEnabled = true;
            this.lbListVideo.ItemHeight = 19;
            this.lbListVideo.Location = new System.Drawing.Point(483, 36);
            this.lbListVideo.Name = "lbListVideo";
            this.lbListVideo.Size = new System.Drawing.Size(205, 270);
            this.lbListVideo.TabIndex = 13;
            this.lbListVideo.SelectedIndexChanged += new System.EventHandler(this.lbListVideo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выбрано исследование :";
            // 
            // labelNameResearch
            // 
            this.labelNameResearch.AutoSize = true;
            this.labelNameResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameResearch.Location = new System.Drawing.Point(216, 46);
            this.labelNameResearch.Name = "labelNameResearch";
            this.labelNameResearch.Size = new System.Drawing.Size(189, 20);
            this.labelNameResearch.TabIndex = 16;
            this.labelNameResearch.Text = "<Имя исследования>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDifPercent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClusterize);
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 116);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кластеризация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Погрешность фиксации взгляда,\r\nотносительно высоты монитора, %";
            // 
            // tbDifPercent
            // 
            this.tbDifPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDifPercent.Location = new System.Drawing.Point(235, 23);
            this.tbDifPercent.Name = "tbDifPercent";
            this.tbDifPercent.Size = new System.Drawing.Size(34, 26);
            this.tbDifPercent.TabIndex = 4;
            this.tbDifPercent.Text = "15";
            this.tbDifPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDifPercent_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGazeMarking);
            this.groupBox2.Location = new System.Drawing.Point(17, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 114);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Наложение маркера взгляда";
            // 
            // btnGazeMarking
            // 
            this.btnGazeMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGazeMarking.Location = new System.Drawing.Point(294, 19);
            this.btnGazeMarking.Name = "btnGazeMarking";
            this.btnGazeMarking.Size = new System.Drawing.Size(137, 29);
            this.btnGazeMarking.TabIndex = 3;
            this.btnGazeMarking.Text = "Применть";
            this.btnGazeMarking.UseVisualStyleBackColor = true;
            this.btnGazeMarking.Click += new System.EventHandler(this.btnGazeMarking_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Предварительная кластеризация приведет \r\nк цветовой дифференциации маркера. \r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Создание нового видео \r\nс отрисовкой маркера взгляда";
            // 
            // FormAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNameResearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStateAnalytics);
            this.Controls.Add(this.lbListVideo);
            this.Controls.Add(this.labelNameProject);
            this.Controls.Add(this.label1);
            this.Name = "FormAnalytics";
            this.Text = "FormAnalytics";
            this.Load += new System.EventHandler(this.FormAnalytics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.Button btnClusterize;
        private System.Windows.Forms.Label labelStateAnalytics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbListVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNameResearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDifPercent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGazeMarking;
    }
}