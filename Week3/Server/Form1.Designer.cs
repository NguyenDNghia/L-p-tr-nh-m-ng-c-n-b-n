namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxReceive = new TextBox();
            labelReceive = new Label();
            SuspendLayout();
            // 
            // textBoxReceive
            // 
            textBoxReceive.Location = new Point(144, 129);
            textBoxReceive.Multiline = true;
            textBoxReceive.Name = "textBoxReceive";
            textBoxReceive.ScrollBars = ScrollBars.Vertical;
            textBoxReceive.Size = new Size(554, 239);
            textBoxReceive.TabIndex = 0;
            // 
            // labelReceive
            // 
            labelReceive.AutoSize = true;
            labelReceive.Location = new Point(28, 72);
            labelReceive.Name = "labelReceive";
            labelReceive.Size = new Size(118, 15);
            labelReceive.TabIndex = 1;
            labelReceive.Text = "Thông tin nhận được";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReceive);
            Controls.Add(textBoxReceive);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxReceive;
        private Label labelReceive;
    }
}