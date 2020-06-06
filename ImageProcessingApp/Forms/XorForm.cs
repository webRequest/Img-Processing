using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingApp.Forms
{
    public partial class XorForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public XorForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            tabControl = tabCtrl;
            pictureList = pctList;
            InitializeComponent();
            AddItems();
        }

        public void AddItems()
        {

            foreach (var item in MainForm.PictureList)
            {
                checkedListBox1.Items.Add(item.Name, CheckState.Unchecked);
            }

        }


        private void btnXor_Click(object sender, EventArgs e)
        {

            List<Bitmap> pictures = new List<Bitmap>();
            if (checkedListBox1.CheckedItems.Count < 2)
            {
                ErrorForm errorForm = new ErrorForm("Nie podano drugiego argumentu!");
                return;
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    pictures.Add((Bitmap)pictureList[i].Image);
                }
            }

            int width = Math.Min(pictures[0].Width, pictures[1].Width);
            int height = Math.Min(pictures[0].Height, pictures[1].Height);

            Bitmap bitmap = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelPic1 = pictures[0].GetPixel(x, y);
                    Color pixelPic2 = pictures[1].GetPixel(x, y);

                    int redFromPic1 = pixelPic1.R;
                    int grenFromPic1 = pixelPic1.G;
                    int blueFromPic1 = pixelPic1.B;

                    int redFromPic2 = pixelPic2.R;
                    int grenFromPic2 = pixelPic2.G;
                    int blueFromPic2 = pixelPic2.B;

                    bitmap.SetPixel(x, y, Color.FromArgb(redFromPic1 ^ redFromPic2, grenFromPic1 ^ grenFromPic2, blueFromPic1 ^ blueFromPic2));
                }
            }

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = bitmap;
            pictureBox.Height = pictureBox.Image.Height;
            pictureBox.Width = pictureBox.Image.Width;
            pictureBox.Name = "xor_wynik";
            pictureList.Add(pictureBox);

            TabPage tabPage1 = new TabPage();
            tabPage1.Name = "tabPage1";
            tabPage1.Text = "xor_wynik";
            tabPage1.Controls.Add(pictureBox);
            tabControl.TabPages.Add(tabPage1);
        }


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;

            }
            //else
            //{
            //    e.NewValue = CheckState.Checked;
            //}
        }
    }
}
