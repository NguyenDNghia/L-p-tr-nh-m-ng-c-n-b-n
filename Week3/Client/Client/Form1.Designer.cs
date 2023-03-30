namespace Client
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
            textBoxIP = new TextBox();
            buttonSend = new Button();
            labelIP = new Label();
            label1 = new Label();
            textBoxPort = new TextBox();
            textBoxMessage = new TextBox();
            labelMessage = new Label();
            textBoxReceive = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(157, 59);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(133, 23);
            textBoxIP.TabIndex = 0;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(677, 136);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 1;
            buttonSend.Text = "Gửi";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += button1_Click;
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Location = new Point(62, 62);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(56, 15);
            labelIP.TabIndex = 2;
            labelIP.Text = "Địa chỉ IP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 62);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Port";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(497, 59);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(124, 23);
            textBoxPort.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(198, 137);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(423, 23);
            textBoxMessage.TabIndex = 5;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(47, 140);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(99, 15);
            labelMessage.TabIndex = 6;
            labelMessage.Text = "Nội dung cần gửi";
            // 
            // textBoxReceive
            // 
            textBoxReceive.Location = new Point(198, 222);
            textBoxReceive.Multiline = true;
            textBoxReceive.Name = "textBoxReceive";
            textBoxReceive.Size = new Size(482, 154);
            textBoxReceive.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 222);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 8;
            label2.Text = "Thông tin nhận được";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxReceive);
            Controls.Add(labelMessage);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxPort);
            Controls.Add(label1);
            Controls.Add(labelIP);
            Controls.Add(buttonSend);
            Controls.Add(textBoxIP);
            Name = "Form1";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIP;
        private Button buttonSend;
        private Label labelIP;
        private Label label1;
        private TextBox textBoxPort;
        private TextBox textBoxMessage;
        private Label labelMessage;
        private TextBox textBoxReceive;
        private Label label2;
    }
}