using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessingApp.Library;

namespace ImageProcessingApp.Forms
{
    public partial class ThresholdingForm : Form
    {
        private int TabNum;
        public ThresholdingForm(int tabNum)
        {
            InitializeComponent();
            label1.Text = "0";
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            trackBar1.TickStyle = TickStyle.BottomRight;
            TabNum = tabNum;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int threshold;
            //Bitmap img = (Bitmap)MainForm.PictureList[TabNum].Image;
            var bitmap = CreateNonIndexedImage(MainForm.PictureList[TabNum].Image);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if (pixel.B >= Convert.ToInt32(label1.Text)) 
                    {
                        threshold = 255;
                    }
                    else 
                    { 
                        threshold = 0;
                    }
                    Color newColor = Color.FromArgb(threshold, threshold, threshold);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            MainForm.PictureList[TabNum].Image = bitmap;
        }

        public static Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }
    }
}
