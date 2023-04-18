namespace Lab02
{
    partial class Lab2_Bai6
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
            textBoxShow = new TextBox();
            pictureBoxShow = new PictureBox();
            treeViewDirectory = new TreeView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            SuspendLayout();
            // 
            // textBoxShow
            // 
            textBoxShow.BackColor = SystemColors.Control;
            textBoxShow.ForeColor = Color.Black;
            textBoxShow.Location = new Point(280, 43);
            textBoxShow.Multiline = true;
            textBoxShow.Name = "textBoxShow";
            textBoxShow.Size = new Size(513, 278);
            textBoxShow.TabIndex = 6;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Location = new Point(280, 55);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(513, 354);
            pictureBoxShow.TabIndex = 5;
            pictureBoxShow.TabStop = false;
            // 
            // treeViewDirectory
            // 
            treeViewDirectory.Location = new Point(8, 42);
            treeViewDirectory.Name = "treeViewDirectory";
            treeViewDirectory.Size = new Size(191, 210);
            treeViewDirectory.TabIndex = 4;
            treeViewDirectory.AfterSelect += treeViewDirectory_AfterSelect;
            treeViewDirectory.NodeMouseClick += treeViewDirectory_NodeMouseDoubleClick;
            // 
            // Lab2_Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxShow);
            Controls.Add(pictureBoxShow);
            Controls.Add(treeViewDirectory);
            Name = "Lab2_Bai6";
            Text = "Lab2_Bai6";
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxShow;
        private PictureBox pictureBoxShow;
        private TreeView treeViewDirectory;
    }
}