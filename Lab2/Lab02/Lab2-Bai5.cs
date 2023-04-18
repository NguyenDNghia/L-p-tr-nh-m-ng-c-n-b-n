using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text files All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxFile1.Text = ofd.FileName;
                }
            }

        }

        private void buttonZip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFile1.Text))
            {
                MessageBox.Show("Vui long chon lai file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxFile1.Focus();
                return;
            }

            string file = textBoxFile1.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zf = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(file);
                    zf.AddFile(file);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(file);
                    zf.SaveProgress += Progress;
                    //zf.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));
                    zf.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, "Output Of " + fi.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }


        private void Progress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }));
            }

        }

        private void ProgressExtract(object sender, Ionic.Zip.ExtractProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }));
            }

        }

        private void buttonUnZip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFile1.Text))
            {
                MessageBox.Show("Vui long chon lai file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxFile1.Focus();
                return;
            }

            string file = textBoxFile1.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zf = new Ionic.Zip.ZipFile())
                {
                    //FileInfo fi = new FileInfo(file);
                    zf.ExtractAll(file, Ionic.Zip.ExtractExistingFileAction.Throw);
                   // System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(file);
                    zf.ExtractProgress += ProgressExtract;
                }
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
