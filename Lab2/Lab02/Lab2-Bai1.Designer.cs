namespace Lab02
{
    partial class Lab2_Bai1
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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonWriteFile = new System.Windows.Forms.Button();
            this.richTextBoxHienThiThongTinFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(43, 46);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(172, 94);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Đọc file";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonWriteFile
            // 
            this.buttonWriteFile.Location = new System.Drawing.Point(43, 198);
            this.buttonWriteFile.Name = "buttonWriteFile";
            this.buttonWriteFile.Size = new System.Drawing.Size(172, 91);
            this.buttonWriteFile.TabIndex = 1;
            this.buttonWriteFile.Text = "Ghi file";
            this.buttonWriteFile.UseVisualStyleBackColor = true;
            this.buttonWriteFile.Click += new System.EventHandler(this.buttonWriteFile_Click);
            // 
            // richTextBoxHienThiThongTinFile
            // 
            this.richTextBoxHienThiThongTinFile.Location = new System.Drawing.Point(318, 46);
            this.richTextBoxHienThiThongTinFile.Name = "richTextBoxHienThiThongTinFile";
            this.richTextBoxHienThiThongTinFile.Size = new System.Drawing.Size(437, 243);
            this.richTextBoxHienThiThongTinFile.TabIndex = 2;
            this.richTextBoxHienThiThongTinFile.Text = "";
            // 
            // Lab2_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxHienThiThongTinFile);
            this.Controls.Add(this.buttonWriteFile);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Lab2_Bai1";
            this.Text = "Lab2_Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonReadFile;
        private Button buttonWriteFile;
        private RichTextBox richTextBoxHienThiThongTinFile;
    }
}