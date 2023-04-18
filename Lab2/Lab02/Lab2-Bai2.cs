using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                richTextBoxShowFile.Text = sr.ReadToEnd();
                textBoxFileName.Text = ofd.SafeFileName.ToString();
                textBoxSize.Text = fs.Length.ToString();
                textBoxURL.Text = fs.Name.ToString();
                

                textBoxLineCount.Text = richTextBoxShowFile.Lines.Count().ToString();
                textBoxCharacterCount.Text = (richTextBoxShowFile.Text.Length - (richTextBoxShowFile.Lines.Count() - 1)).ToString();

                string wordSTR;
                wordSTR = richTextBoxShowFile.Text;
                int i = 0;
                int mywordSTR = 1;
                while (i <= wordSTR.Length - 1)
                {
                    if (wordSTR[i] == ' ' || wordSTR[i] == '\n' || wordSTR[i] == '\t')
                    {
                        mywordSTR += 1;
                    }
                    i++;
                }
                textBoxwordSTRCount.Text = mywordSTR.ToString();

                fs.Close();
                //MessageBox.Show("Đọc file thành công");
            }
            catch
            {
                MessageBox.Show("Đọc file không thành công");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
