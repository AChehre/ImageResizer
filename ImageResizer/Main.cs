using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void buttonChooseImagePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxImagePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonChooseTargetImagePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetImagePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }



        private void buttonLoad_Click(object sender, EventArgs e)
        {
            checkedListBoxImages.Items.Clear();
            if (System.IO.Directory.Exists(textBoxImagePath.Text))
            {
                IList<ImageItem> list = new List<ImageItem>();
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(textBoxImagePath.Text);
                foreach (var item in dirinfo.GetFiles("*.jpg"))
                {
                    string title = System.IO.Path.GetFileNameWithoutExtension(item.Name);

                    list.Add(new ImageItem(title, item));
                }

                checkedListBoxImages.DataSource = list;
                checkedListBoxImages.DisplayMember = "title";

                for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
                {
                    checkedListBoxImages.SetItemChecked(i, true);
                }


            }
        }
        private Size CalculateSize(Size size, int percentage)
        {
            Size newsize = new Size(0,0);
            newsize.Height = ((size.Height * percentage) / 100);
            newsize.Width = ((size.Width * percentage) / 100);
            return newsize;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBoxTargetImagePath.Text))
            {
                int count = checkedListBoxImages.CheckedItems.Count;
                int progress = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = count;
                progressBar1.Minimum = 0;
                foreach (var item in checkedListBoxImages.CheckedItems)
                {
                    Application.DoEvents();
                    try
                    {
                        Image image = Image.FromFile(((ImageItem)item).File.FullName);
                        Size size = CalculateSize(image.Size, Convert.ToInt32(comboBoxResolution.Text));
                        image = ResizeImage(image, size);
                        string filepath = System.IO.Path.Combine(textBoxTargetImagePath.Text, ((ImageItem)item).File.Name);
                        image.Save(filepath);
                        progress++;
                        progressBar1.Value = progress;
                        Application.DoEvents();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                MessageBox.Show("پایان");
            }
            else
            {
                MessageBox.Show("مسیر تصاویر خروجی درست وارد نشده است.");
            }


        }

        public static Image ResizeImage(Image image, Size newsize)
        {
            return (Image)(new Bitmap(image, newsize));
        }

    }
}
