using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class BlendingForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public BlendingForm(TabControl tabCtrl, List<PictureBox> pctList)
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;

            }
        }

        private void btnClick_Click(object sender, EventArgs e)
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

            var src1 = pictures[0].ToImage<Bgr, byte>();
            var src2 = pictures[1].ToImage<Bgr, byte>();

            src1 = src1.Resize(width, height, interpolationType: Emgu.CV.CvEnum.Inter.Linear);
            src2 = src2.Resize(width, height, interpolationType: Emgu.CV.CvEnum.Inter.Linear);

            var imgDst = new Image<Bgr, byte>(width, height, new Bgr(0, 0, 0));

            Emgu.CV.CvInvoke.AddWeighted(src1, 0.5, src2, 0.7, -100, imgDst); 

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = imgDst.ToBitmap();
            pictureBox.Height = pictureBox.Image.Height;
            pictureBox.Width = pictureBox.Image.Width;
            pictureBox.Name = "blending_wynik";
            pictureList.Add(pictureBox);

            TabPage tabPage1 = new TabPage();
            tabPage1.Name = "tabPage1";
            tabPage1.Text = "blending_wynik";
            tabPage1.Controls.Add(pictureBox);
            tabControl.TabPages.Add(tabPage1);
        }
    }
}
