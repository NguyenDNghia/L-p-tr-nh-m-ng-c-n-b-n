namespace Lab02
{
    partial class Lab2_Bai5
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
            textBoxFile1 = new TextBox();
            labelFile1 = new Label();
            buttonZip = new Button();
            buttonUnZip = new Button();
            buttonBrowse = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // textBoxFile1
            // 
            textBoxFile1.Location = new Point(199, 76);
            textBoxFile1.Name = "textBoxFile1";
            textBoxFile1.Size = new Size(405, 23);
            textBoxFile1.TabIndex = 0;
            // 
            // labelFile1
            // 
            labelFile1.AutoSize = true;
            labelFile1.Location = new Point(93, 81);
            labelFile1.Name = "labelFile1";
            labelFile1.Size = new Size(25, 15);
            labelFile1.TabIndex = 1;
            labelFile1.Text = "File";
            // 
            // buttonZip
            // 
            buttonZip.Location = new Point(228, 155);
            buttonZip.Name = "buttonZip";
            buttonZip.Size = new Size(75, 23);
            buttonZip.TabIndex = 2;
            buttonZip.Text = "Zip";
            buttonZip.UseVisualStyleBackColor = true;
            buttonZip.Click += buttonZip_Click;
            // 
            // buttonUnZip
            // 
            buttonUnZip.Location = new Point(470, 155);
            buttonUnZip.Name = "buttonUnZip";
            buttonUnZip.Size = new Size(75, 23);
            buttonUnZip.TabIndex = 5;
            buttonUnZip.Text = "UnZip";
            buttonUnZip.UseVisualStyleBackColor = true;
            buttonUnZip.Click += buttonUnZip_Click;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(652, 76);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(44, 23);
            buttonBrowse.TabIndex = 6;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(83, 218);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(644, 23);
            progressBar1.TabIndex = 8;
            // 
            // Lab2_Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(buttonBrowse);
            Controls.Add(buttonUnZip);
            Controls.Add(buttonZip);
            Controls.Add(labelFile1);
            Controls.Add(textBoxFile1);
            Name = "Lab2_Bai5";
            Text = "Lab2_Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFile1;
        private Label labelFile1;
        private Button buttonZip;
        private Button buttonUnZip;
        private Button buttonBrowse;
        private ProgressBar progressBar1;
    }
}