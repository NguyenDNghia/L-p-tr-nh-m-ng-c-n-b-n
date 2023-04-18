namespace Lab02
{
    partial class Lab2_Bai2
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
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelLineCount = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelCharacterCount = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxLineCount = new System.Windows.Forms.TextBox();
            this.textBoxwordSTRCount = new System.Windows.Forms.TextBox();
            this.textBoxCharacterCount = new System.Windows.Forms.TextBox();
            this.richTextBoxShowFile = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(32, 85);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(106, 30);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "File Name";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(32, 178);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(50, 30);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(32, 275);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(50, 30);
            this.labelURL.TabIndex = 2;
            this.labelURL.Text = "URL";
            // 
            // labelLineCount
            // 
            this.labelLineCount.AutoSize = true;
            this.labelLineCount.Location = new System.Drawing.Point(32, 361);
            this.labelLineCount.Name = "labelLineCount";
            this.labelLineCount.Size = new System.Drawing.Size(113, 30);
            this.labelLineCount.TabIndex = 3;
            this.labelLineCount.Text = "Line Count";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Location = new System.Drawing.Point(32, 454);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(125, 30);
            this.labelWordCount.TabIndex = 4;
            this.labelWordCount.Text = "Word Count";
            // 
            // labelCharacterCount
            // 
            this.labelCharacterCount.AutoSize = true;
            this.labelCharacterCount.Location = new System.Drawing.Point(32, 546);
            this.labelCharacterCount.Name = "labelCharacterCount";
            this.labelCharacterCount.Size = new System.Drawing.Size(164, 30);
            this.labelCharacterCount.TabIndex = 5;
            this.labelCharacterCount.Text = "Character Count";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(202, 82);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(237, 35);
            this.textBoxFileName.TabIndex = 6;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(202, 175);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(237, 35);
            this.textBoxSize.TabIndex = 7;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(202, 272);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(237, 35);
            this.textBoxURL.TabIndex = 8;
            // 
            // textBoxLineCount
            // 
            this.textBoxLineCount.Location = new System.Drawing.Point(202, 358);
            this.textBoxLineCount.Name = "textBoxLineCount";
            this.textBoxLineCount.Size = new System.Drawing.Size(237, 35);
            this.textBoxLineCount.TabIndex = 9;
            // 
            // textBoxwordSTRCount
            // 
            this.textBoxwordSTRCount.Location = new System.Drawing.Point(202, 454);
            this.textBoxwordSTRCount.Name = "textBoxwordSTRCount";
            this.textBoxwordSTRCount.Size = new System.Drawing.Size(237, 35);
            this.textBoxwordSTRCount.TabIndex = 10;
            // 
            // textBoxCharacterCount
            // 
            this.textBoxCharacterCount.Location = new System.Drawing.Point(202, 541);
            this.textBoxCharacterCount.Name = "textBoxCharacterCount";
            this.textBoxCharacterCount.Size = new System.Drawing.Size(237, 35);
            this.textBoxCharacterCount.TabIndex = 11;
            // 
            // richTextBoxShowFile
            // 
            this.richTextBoxShowFile.Location = new System.Drawing.Point(498, 68);
            this.richTextBoxShowFile.Name = "richTextBoxShowFile";
            this.richTextBoxShowFile.Size = new System.Drawing.Size(433, 512);
            this.richTextBoxShowFile.TabIndex = 12;
            this.richTextBoxShowFile.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(50, 622);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(50, 12);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(131, 40);
            this.buttonReadFile.TabIndex = 14;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // Lab2_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 683);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.richTextBoxShowFile);
            this.Controls.Add(this.textBoxCharacterCount);
            this.Controls.Add(this.textBoxwordSTRCount);
            this.Controls.Add(this.textBoxLineCount);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelCharacterCount);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelLineCount);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelFileName);
            this.Name = "Lab2_Bai2";
            this.Text = "Lab2_Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFileName;
        private Label labelSize;
        private Label labelURL;
        private Label labelLineCount;
        private Label labelWordCount;
        private Label labelCharacterCount;
        private TextBox textBoxFileName;
        private TextBox textBoxSize;
        private TextBox textBoxURL;
        private TextBox textBoxLineCount;
        private TextBox textBoxwordSTRCount;
        private TextBox textBoxCharacterCount;
        private RichTextBox richTextBoxShowFile;
        private Button buttonExit;
        private Button buttonReadFile;
    }
}