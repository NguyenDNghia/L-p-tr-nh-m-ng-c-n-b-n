namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBai1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 lab2_Bai1 = new Lab2_Bai1();
            this.Hide();
            lab2_Bai1.ShowDialog();
            this.Show();
        }

        private void buttonBai2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 lab2_Bai2 = new Lab2_Bai2();
            this.Hide();
            lab2_Bai2.ShowDialog();
            this.Show();
        }

        private void buttonBai5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 lab2_Bai5 = new Lab2_Bai5();
            this.Hide();
            lab2_Bai5.ShowDialog();
            this.Show();
        }

        private void buttonBai3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 lab2_Bai3 = new Lab2_Bai3();
            this.Hide();
            lab2_Bai3.ShowDialog();
            this.Show();
        }

        private void buttonBai4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 lab2_Bai4 = new Lab2_Bai4();
            this.Hide();
            lab2_Bai4.ShowDialog();
            this.Show();
        }

        private void buttonBai6_Click(object sender, EventArgs e)
        {
            Lab2_Bai6 lab2_Bai6 = new Lab2_Bai6();
            this.Hide();
            lab2_Bai6.ShowDialog();
            this.Show();
        }
    }
}