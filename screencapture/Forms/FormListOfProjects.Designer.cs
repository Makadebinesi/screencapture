using System.Drawing;

namespace screencapture
{
    partial class FormListOfProjects
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbListProjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 285);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 34);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbListProjects
            // 
            this.lbListProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbListProjects.FormattingEnabled = true;
            this.lbListProjects.ItemHeight = 20;
            this.lbListProjects.Location = new System.Drawing.Point(12, 12);
            this.lbListProjects.Name = "lbListProjects";
            this.lbListProjects.Size = new System.Drawing.Size(226, 264);
            this.lbListProjects.TabIndex = 3;
            this.lbListProjects.SelectedIndexChanged += new System.EventHandler(this.lbListProjects_SelectedIndexChanged);
            this.lbListProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbListProjects_MouseDoubleClick);
            // 
            // FormListOfProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 331);
            this.Controls.Add(this.lbListProjects);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(150, 200);
            this.MaximizeBox = false;
            this.Name = "FormListOfProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список проектов";
            this.Load += new System.EventHandler(this.FormListOfProject_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lbListProjects;
    }
}