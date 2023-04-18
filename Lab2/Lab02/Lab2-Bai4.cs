using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Lab02
{
    public partial class Lab2_Bai4 : Form
    {
        List<SinhVien> ds = new List<SinhVien>();
        int i = 1;
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();

            if (TextBoxPhone.Text.Length != 10 || !TextBoxPhone.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            if (TextBoxID.Text.Length != 8)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ");
                return;
            }

            try
            {
                double course1 =  Double.Parse(TextBoxCourse1.Text.Trim());
                double course2 =  Double.Parse(TextBoxCourse2.Text.Trim());
                double course3 =  Double.Parse(TextBoxCourse3.Text.Trim());
                double avg = (course1 + course2 + course3) / (double)3;



                //if (course1 < 0 || course1 > 10 || course2 < 0 || course2 > 10 || course3 < 0 || course3 > 10)
                ////if (Convert.ToInt32(TextBoxCourse1.Text) < 0 || Convert.ToInt32(TextBoxCourse1.Text) > 10
                ////        || Convert.ToInt32(TextBoxCourse2.Text) < 0 || Convert.ToInt32(TextBoxCourse2.Text) > 10 || Convert.ToInt32(TextBoxCourse3.Text) < 0 || Convert.ToInt32(TextBoxCourse3.Text) > 10)
                //    {
                //        MessageBox.Show("Điểm không hợp lệ");
                //        return;
                //    }
                
                
                sv.Name = TextBoxName.Text;
                sv.ID = TextBoxID.Text;
                sv.Phone = TextBoxPhone.Text;
                sv.Course1 = course1;
                sv.Course2 = course2;
                sv.Course3 = course3;
                ds.Add(sv);
                MessageBox.Show("Nhập thông tin sinh viên thành công");
                richTextBoxShow.Text += TextBoxName.Text + "\n";
                richTextBoxShow.Text += TextBoxID.Text + "\n";
                richTextBoxShow.Text += TextBoxPhone.Text + "\n";
                richTextBoxShow.Text += TextBoxCourse1.Text + "\n";
                richTextBoxShow.Text += TextBoxCourse2.Text + "\n";
                richTextBoxShow.Text += TextBoxCourse3.Text + "\n";
                richTextBoxShow.Text += avg.ToString() + "\n";
            }
            catch { MessageBox.Show("Điểm phải là số"); }

        }

        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("input4.txt", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, ds);
            }
            MessageBox.Show("Thêm sinh viên vào thành công");
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsSinhVien;
            using (FileStream fileStream = new FileStream("input4.txt", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dsSinhVien = (List<SinhVien>)binaryFormatter.Deserialize(fileStream);
            }

            foreach (SinhVien sv in ds)
            {
                sv.Average = (sv.Course1 + sv.Course2 + sv.Course3) / 3;
            }
            MessageBox.Show("Đọc file thành công");

            using (FileStream fileStream = new FileStream("output4.txt", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, ds);
            }


            SinhVien sinhVien = ds[i - 1];
            TextBoxName2.Text = sinhVien.Name.ToString();
            TextBoxID2.Text = sinhVien.ID.ToString();
            TextBoxPhone2.Text = sinhVien.Phone.ToString();
            TextBoxCourse1_2.Text = sinhVien.Course1.ToString();
            TextBoxCourse2_2.Text = sinhVien.Course2.ToString();
            TextBoxCourse3_2.Text = sinhVien.Course3.ToString();
            double avg = (sinhVien.Course1 + sinhVien.Course2 + sinhVien.Course3) / 3;
            TextBoxAverage.Text = "0";
            MessageBox.Show($"Thông tin sinh viên \n" +
                $"Họ tên: {sinhVien.Name}\n" +
                $"MSSV: {sinhVien.ID}\n" +
                $"Điện thoại: {sinhVien.Phone}\n" +
                $"Điểm môn 1: {sinhVien.Course1}\n" +
                $"Điểm môn 2: {sinhVien.Course2}\n" +
                $"Điểm môn 3: {sinhVien.Course3}\n" +
                $"Điểm trung bình: {avg}");
            labelIndex.Text = i.ToString();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;

                try
                {
                    SinhVien sinhVien = ds[i - 1];
                    TextBoxName2.Text = sinhVien.Name.ToString();
                    TextBoxID2.Text = sinhVien.ID.ToString();
                    TextBoxPhone2.Text = sinhVien.Phone.ToString();
                    TextBoxCourse1_2.Text = sinhVien.Course1.ToString();
                    TextBoxCourse2_2.Text = sinhVien.Course2.ToString();
                    TextBoxCourse3_2.Text = sinhVien.Course3.ToString();
                    double avg = (sinhVien.Course1 + sinhVien.Course2 + sinhVien.Course3) / 3;
                    TextBoxAverage.Text = "0";
                    MessageBox.Show($"Thông tin sinh viên \n" +
                        $"Họ tên: {sinhVien.Name}\n" +
                        $"MSSV: {sinhVien.ID}\n" +
                        $"Điện thoại: {sinhVien.Phone}\n" +
                        $"Điểm môn 1: {sinhVien.Course1}\n" +
                        $"Điểm môn 2: {sinhVien.Course2}\n" +
                        $"Điểm môn 3: {sinhVien.Course3}\n" +
                        $"Điểm trung bình: {avg}");
                    labelIndex.Text = i.ToString();
                }
                catch { }

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < ds.Count)
            {

                i++;
                try
                {
                    SinhVien sinhVien = ds[i - 1];
                    TextBoxName2.Text = sinhVien.Name.ToString();
                    TextBoxID2.Text = sinhVien.ID.ToString();
                    TextBoxPhone2.Text = sinhVien.Phone.ToString();
                    TextBoxCourse1_2.Text = sinhVien.Course1.ToString();
                    TextBoxCourse2_2.Text = sinhVien.Course2.ToString();
                    TextBoxCourse3_2.Text = sinhVien.Course3.ToString();
                    double avg = (sinhVien.Course1 + sinhVien.Course2 + sinhVien.Course3) / 3;
                    TextBoxAverage.Text = "0";
                    MessageBox.Show($"Thông tin sinh viên \n" +
                        $"Họ tên: {sinhVien.Name}\n" +
                        $"MSSV: {sinhVien.ID}\n" +
                        $"Điện thoại: {sinhVien.Phone}\n" +
                        $"Điểm môn 1: {sinhVien.Course1}\n" +
                        $"Điểm môn 2: {sinhVien.Course2}\n" +
                        $"Điểm môn 3: {sinhVien.Course3}\n" +
                        $"Điểm trung bình: {avg}");
                    labelIndex.Text = i.ToString();
                }
                catch { }
            }
        }
    }
}
