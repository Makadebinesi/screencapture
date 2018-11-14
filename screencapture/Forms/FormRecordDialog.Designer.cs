namespace screencapture
{
    partial class FormRecordDialog
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
            this.btnStartRec = new System.Windows.Forms.Button();
            this.btnCancelRD = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.cbOpenResearchObject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStartRec
            // 
            this.btnStartRec.Location = new System.Drawing.Point(32, 214);
            this.btnStartRec.Name = "btnStartRec";
            this.btnStartRec.Size = new System.Drawing.Size(118, 35);
            this.btnStartRec.TabIndex = 0;
            this.btnStartRec.Text = "Запись";
            this.btnStartRec.UseVisualStyleBackColor = true;
            this.btnStartRec.Click += new System.EventHandler(this.btnStartRec_Click);
            // 
            // btnCancelRD
            // 
            this.btnCancelRD.Location = new System.Drawing.Point(249, 214);
            this.btnCancelRD.Name = "btnCancelRD";
            this.btnCancelRD.Size = new System.Drawing.Size(115, 35);
            this.btnCancelRD.TabIndex = 1;
            this.btnCancelRD.Text = "Отмена";
            this.btnCancelRD.UseVisualStyleBackColor = true;
            this.btnCancelRD.Click += new System.EventHandler(this.btnCancelRD_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(32, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(332, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(32, 83);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(332, 96);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(28, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя \\ Название";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(28, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(91, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание";
            // 
            // cbOpenResearchObject
            // 
            this.cbOpenResearchObject.AutoSize = true;
            this.cbOpenResearchObject.Checked = true;
            this.cbOpenResearchObject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenResearchObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOpenResearchObject.Location = new System.Drawing.Point(32, 184);
            this.cbOpenResearchObject.Name = "cbOpenResearchObject";
            this.cbOpenResearchObject.Size = new System.Drawing.Size(293, 24);
            this.cbOpenResearchObject.TabIndex = 6;
            this.cbOpenResearchObject.Text = "Показывать объект исследования";
            this.cbOpenResearchObject.UseVisualStyleBackColor = true;
            // 
            // FormRecordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.cbOpenResearchObject);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancelRD);
            this.Controls.Add(this.btnStartRec);
            this.Name = "FormRecordDialog";
            this.Text = "FormRecordDialog";
            this.Load += new System.EventHandler(this.FormRecordDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartRec;
        private System.Windows.Forms.Button btnCancelRD;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckBox cbOpenResearchObject;
    }
}