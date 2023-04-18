namespace Lab02
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
            buttonBai1 = new Button();
            buttonBai2 = new Button();
            buttonBai3 = new Button();
            buttonBai4 = new Button();
            buttonBai5 = new Button();
            buttonBai6 = new Button();
            SuspendLayout();
            // 
            // buttonBai1
            // 
            buttonBai1.Location = new Point(54, 51);
            buttonBai1.Margin = new Padding(2);
            buttonBai1.Name = "buttonBai1";
            buttonBai1.Size = new Size(76, 20);
            buttonBai1.TabIndex = 0;
            buttonBai1.Text = "Bài 1";
            buttonBai1.UseVisualStyleBackColor = true;
            // 
            // buttonBai2
            // 
            buttonBai2.Location = new Point(194, 51);
            buttonBai2.Margin = new Padding(2);
            buttonBai2.Name = "buttonBai2";
            buttonBai2.Size = new Size(76, 20);
            buttonBai2.TabIndex = 1;
            buttonBai2.Text = "Bài 2";
            buttonBai2.UseVisualStyleBackColor = true;
            // 
            // buttonBai3
            // 
            buttonBai3.Location = new Point(335, 51);
            buttonBai3.Margin = new Padding(2);
            buttonBai3.Name = "buttonBai3";
            buttonBai3.Size = new Size(76, 20);
            buttonBai3.TabIndex = 2;
            buttonBai3.Text = "Bài 3";
            buttonBai3.UseVisualStyleBackColor = true;
            buttonBai3.Click += buttonBai3_Click;
            // 
            // buttonBai4
            // 
            buttonBai4.Location = new Point(54, 130);
            buttonBai4.Margin = new Padding(2);
            buttonBai4.Name = "buttonBai4";
            buttonBai4.Size = new Size(76, 20);
            buttonBai4.TabIndex = 3;
            buttonBai4.Text = "Bài 4";
            buttonBai4.UseVisualStyleBackColor = true;
            buttonBai4.Click += buttonBai4_Click;
            // 
            // buttonBai5
            // 
            buttonBai5.Location = new Point(194, 130);
            buttonBai5.Margin = new Padding(2);
            buttonBai5.Name = "buttonBai5";
            buttonBai5.Size = new Size(76, 20);
            buttonBai5.TabIndex = 4;
            buttonBai5.Text = "Bài 5";
            buttonBai5.UseVisualStyleBackColor = true;
            // 
            // buttonBai6
            // 
            buttonBai6.Location = new Point(335, 130);
            buttonBai6.Margin = new Padding(2);
            buttonBai6.Name = "buttonBai6";
            buttonBai6.Size = new Size(76, 20);
            buttonBai6.TabIndex = 5;
            buttonBai6.Text = "Bài 6";
            buttonBai6.UseVisualStyleBackColor = true;
            buttonBai6.Click += buttonBai6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(buttonBai6);
            Controls.Add(buttonBai5);
            Controls.Add(buttonBai4);
            Controls.Add(buttonBai3);
            Controls.Add(buttonBai2);
            Controls.Add(buttonBai1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBai1;
        private Button buttonBai2;
        private Button buttonBai3;
        private Button buttonBai4;
        private Button buttonBai5;
        private Button buttonBai6;
    }
}