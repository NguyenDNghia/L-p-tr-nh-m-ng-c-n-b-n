using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Path = System.IO.Path;

namespace Lab02
{
    public partial class Lab2_Bai6 : Form
    {
        string path = @"D:\";
        int x = 0;
        public Lab2_Bai6()
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {
                TreeNode tree = new TreeNode() { Text = path };
                treeViewDirectory.Nodes.Add(tree);
                Load(tree);
            }
        }

        void Load(TreeNode tree)
        {
            if (tree == null)
                return;
            try
            {
                var fileList = new DirectoryInfo(tree.Text).GetFiles();

                if (fileList.Length > 0)
                {
                    foreach (FileInfo file in fileList)
                    {
                        if (x == 0)
                        {
                            TreeNode node = new TreeNode()
                            {
                                Text = Path.Combine(tree.Text, file.Name)
                            }; // Thêm root.Text vào đường dẫn của file
                            tree.Nodes.Add(node);
                            x = 1;
                        }
                        else
                        {
                            TreeNode node = new TreeNode() { Text = file.Name };
                            tree.Nodes.Add(node);
                        }
                    }
                }

                var folderList = new DirectoryInfo(tree.Text).GetDirectories();

                if (folderList.Length > 0)
                {
                    foreach (DirectoryInfo item in folderList)
                    {
                        if (Directory.Exists(item.FullName))
                        {
                            TreeNode node = new TreeNode() { Text = item.FullName };
                            tree.Nodes.Add(node);
                            Load(node);
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeViewDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.FullPath;

            if (!Path.IsPathRooted(selectedPath))
            {

                selectedPath = Path.Combine(path, selectedPath);
            }

            MessageBox.Show(selectedPath);

        }


        private void treeViewDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fullPath = e.Node.FullPath;
            string removedRootPath = fullPath.Substring(path.Length + 1);

            string extension = Path.GetExtension(removedRootPath);
            if (extension != null)
            {
                if (extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    string content = File.ReadAllText(removedRootPath);

                    textBoxShow.Text = content;
                    textBoxShow.BringToFront();

                    pictureBoxShow.Image = null;
                }
                else
                {
                    pictureBoxShow.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBoxShow.Image = Image.FromFile(removedRootPath);
                    pictureBoxShow.BringToFront();
                    textBoxShow.Text = string.Empty;

                }
            }

        }
    }
}
