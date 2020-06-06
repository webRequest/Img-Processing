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
    public partial class PrewittForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public PrewittForm(TabControl tabCtrl, List<PictureBox> pctList)
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
                case "E":
                    PrewittCalc(new float[,] { { -1, 0, 1 }, { -1, 1, 1 }, { -1, 0, 1 } });
                    break;
                case "SE":
                    PrewittCalc(new float[,] { { -1, -1, 0 }, { -1, 1, 1 }, { 0, 1, 1 } });
                    break;
                case "S":
                    PrewittCalc(new float[,] { { -1, -1, -1 }, { 0, 1, 0 }, { 1, 1, 1 } });
                    break;
                case "SW":
                    PrewittCalc(new float[,] { { 0, -1, -1 }, { 1, 1, -1 }, { 1, 1, 0 } });
                    break;
                case "W":
                    PrewittCalc(new float[,] { { 1, 0, -1 }, { 1, 1, -1 }, { 1, 0, -1 } });
                    break;
                case "NW":
                    PrewittCalc(new float[,] { { 1, 1, 0 }, { 1, 1, -1 }, { 0, -1, -1 } });
                    break;
                case "N":
                    PrewittCalc(new float[,] { { 1, 1, 1 }, { 0, 1, 0 }, { -1, -1, -1 } });
                    break;
                case "NE":
                    PrewittCalc(new float[,] { { 0, 1, 1 }, { -1, 1, 1 }, { -1, -1, 0 } });
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

        private void PrewittCalc(float[,] matrix)
        {
            ConvolutionKernelF kernel = new ConvolutionKernelF(matrix);

            var img = ((Bitmap)pictureList[tabControl.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(pictureList[tabControl.SelectedIndex].Image.Width,
                pictureList[tabControl.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, 1), 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            pictureList[tabControl.SelectedIndex].Image = imgDst.ToBitmap();
            GC.Collect();
        }
    }
}
