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
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }
        OpenFileDialog mainOfd = new OpenFileDialog();
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                mainOfd = ofd;
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                richTextBoxHienThiThongTinFile.Text = sr.ReadToEnd();
                fs.Close();
                MessageBox.Show("Đọc file thành công");
            }
            catch
            {
                MessageBox.Show("Đọc file không thành công");
            }
        }

        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(mainOfd.FileName, FileMode.OpenOrCreate);
                FileStream fsWrite = new FileStream("Output1.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fsWrite);
                StreamReader sr = new StreamReader(fs);
                string result = sr.ReadToEnd();
                result = result.ToUpper();
                sw.Write(result);
                sw.Flush();
                fs.Close();
                fsWrite.Close();
                FileStream fsRead = new FileStream("Output1.txt", FileMode.Open);
                StreamReader resultRead = new StreamReader(fsRead);
                richTextBoxHienThiThongTinFile.Text = resultRead.ReadToEnd();
                fsRead.Close();
                MessageBox.Show("Ghi file thành công");
            }
            catch
            {
                MessageBox.Show("Ghi file không thành công");
            }

        }
    }
}
