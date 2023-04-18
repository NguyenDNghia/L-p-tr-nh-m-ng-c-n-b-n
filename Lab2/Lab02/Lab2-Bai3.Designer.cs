namespace Lab02
{
    partial class Lab2_Bai3
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonWriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(75, 53);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(649, 248);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(159, 353);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(131, 40);
            this.buttonReadFile.TabIndex = 1;
            this.buttonReadFile.Text = "Đọc File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonWriteFile
            // 
            this.buttonWriteFile.Location = new System.Drawing.Point(518, 353);
            this.buttonWriteFile.Name = "buttonWriteFile";
            this.buttonWriteFile.Size = new System.Drawing.Size(131, 40);
            this.buttonWriteFile.TabIndex = 2;
            this.buttonWriteFile.Text = "Ghi File";
            this.buttonWriteFile.UseVisualStyleBackColor = true;
            this.buttonWriteFile.Click += new System.EventHandler(this.buttonWriteFile_Click);
            // 
            // Lab2_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWriteFile);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "Lab2_Bai3";
            this.Text = "Lab2_Bai3";
            this.Load += new System.EventHandler(this.Lab2_Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxInput;
        private Button buttonReadFile;
        private Button buttonWriteFile;
    }
}