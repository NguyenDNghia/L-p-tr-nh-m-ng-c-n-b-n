using Microsoft.VisualBasic;
using System;
using System.Collections;
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
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }


        private void Lab2_Bai3_Load(object sender, EventArgs e)
        {

        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBoxInput.Text = sr.ReadToEnd();
            fs.Close();
        }


        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            Stack stack = new Stack();
            string wordSTR = richTextBoxInput.Text, text = "";
           
                //for (int i = 0; i < wordSTR.Length; i++)
                //{
                //    while (wordSTR[i] != '\n')
                //    {
                //        text += wordSTR[i];
                //        i++;
                //    }
                //    stack.Push(text);
                //    text = "";
                //}

                foreach (char c in wordSTR)
                {
                    if (c != '\n')
                        text += c;
                    else if (c == '\n')
                    {
                        stack.Push(text);
                        text = "";
                    }
                }
                stack.Push(text);
                richTextBoxInput.Text = "";
                int length = stack.Count;
                string s;
            
          


            for (int i = 0; i < length; i++)
            {
                try
                {
                    s = stack.Pop().ToString();

                    DataTable dt = new DataTable();
                    richTextBoxInput.Text += s + " = " + Convert.ToDouble(dt.Compute(s, string.Empty)).ToString() + "  \n";
                }
                catch { }
               
            }

            try
            {
                FileStream fsWrite = new FileStream("Output3.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fsWrite);
                sw.WriteLine(richTextBoxInput.Text);
                sw.Flush();
                fsWrite.Close();
                MessageBox.Show("Xuất file thành công");
            }
            catch {}
        }
    }
}
