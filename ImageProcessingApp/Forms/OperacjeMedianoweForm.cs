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
    public partial class OperacjeMedianoweForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public OperacjeMedianoweForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            tabControl = tabCtrl;
            pictureList = pctList;
            InitializeComponent();
        }


        private void btnClick_Click(object sender, EventArgs e)
        {
            string str = String.Empty;
            foreach (string item in checkedListBox1.CheckedItems)
            {
                str = item;
            }
            switch (str)
            {
                case "3x3":
                    MedCalc(3);
                    break;
                case "5x5":
                    MedCalc(5);
                    break;
                case "7x7":
                    MedCalc(7);
                    break;
                default:
                    break;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 1)
            {
                e.NewValue = CheckState.Unchecked;

            }
            else
            {
                e.NewValue = CheckState.Checked;
            }
        }

        private void MedCalc(int size)
        {
            var img = ((Bitmap)pictureList[tabControl.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(pictureList[tabControl.SelectedIndex].Image.Width,
                pictureList[tabControl.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.MedianBlur(img, imgDst, size);
            pictureList[tabControl.SelectedIndex].Image = imgDst.ToBitmap();
            GC.Collect();
        }
    }
}
