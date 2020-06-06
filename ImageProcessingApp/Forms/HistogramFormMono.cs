using ImageProcessingApp.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingApp.Forms
{
    public partial class HistogramFormMono : Form
    {
        private int[] Red { get; set; }
        private int[] Green { get; set; }
        private int[] Blue { get; set; }

        private int TabNum { get; set; }
        //public HistogramFormRgb formRgb;
        //private PictureBox picture;
        public HistogramFormMono(int[] r, int[] g, int[] b, int tabNum)
        {
            InitializeComponent();
            Red = r;
            Green = g;
            Blue = b;
            TabNum = tabNum;
            DrawHisto();
        }

        private void DrawHisto()
        {
            for (int x = 0; x < MainForm.PictureList[TabNum].Width; x++)
            {
                for (int y = 0; y < MainForm.PictureList[TabNum].Height; y++)
                {
                    Color pixel = ((Bitmap)MainForm.PictureList[TabNum].Image).GetPixel(x, y);
                    Red[pixel.R]++;
                    Green[pixel.G]++;
                    Blue[pixel.B]++;
                }
            }

            histogramChartMono.Series["red"].Points.Clear();
            histogramChartMono.Series["green"].Points.Clear();
            histogramChartMono.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                histogramChartMono.Series["red"].Points.AddXY(i, Red[i]);
                histogramChartMono.Series["green"].Points.AddXY(i, Green[i]);
                histogramChartMono.Series["blue"].Points.AddXY(i, Blue[i]);
            }
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();

            Show();
        }

        private void btnHistoStretching_Click(object sender, EventArgs e)
        {
            int[] LUTred = IPALibrary.CalculateLUT(Red);
            int[] LUTgreen = IPALibrary.CalculateLUT(Green);
            int[] LUTblue = IPALibrary.CalculateLUT(Blue);

            Red = new int[256];
            Green = new int[256];
            Blue = new int[256];
            Bitmap oldBitmap = (Bitmap)MainForm.PictureList[TabNum].Image;
            Bitmap newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height, PixelFormat.Format24bppRgb);
            for (int x = 0; x < MainForm.PictureList[TabNum].Width; x++)
            {
                for (int y = 0; y < MainForm.PictureList[TabNum].Height; y++)
                {
                    Color pixel = oldBitmap.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(LUTred[pixel.R], LUTgreen[pixel.G], LUTblue[pixel.B]);
                    newBitmap.SetPixel(x, y, newPixel);
                    Red[newPixel.R]++;
                    Green[newPixel.G]++;
                    Blue[newPixel.B]++;
                }
            }
            MainForm.PictureList[TabNum].Image = newBitmap;

            histogramChartMono.Series["red"].Points.Clear();
            histogramChartMono.Series["green"].Points.Clear();
            histogramChartMono.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                histogramChartMono.Series["red"].Points.AddXY(i, Red[i]);
                histogramChartMono.Series["green"].Points.AddXY(i, Green[i]);
                histogramChartMono.Series["blue"].Points.AddXY(i, Blue[i]);
            }
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();
        }

        private void btnHistogramEqualization_Click(object sender, EventArgs e)
        {

            int[] LUTred = IPALibrary.CalculateLUTForEqualization(Red, MainForm.PictureList[TabNum].Image.Width * MainForm.PictureList[TabNum].Image.Height);
            int[] LUTgreen = IPALibrary.CalculateLUTForEqualization(Green, MainForm.PictureList[TabNum].Image.Width * MainForm.PictureList[TabNum].Image.Height);
            int[] LUTblue = IPALibrary.CalculateLUTForEqualization(Blue, MainForm.PictureList[TabNum].Image.Width * MainForm.PictureList[TabNum].Image.Height);

            Red = new int[256];
            Green = new int[256];
            Blue = new int[256];
            Bitmap oldBitmap = (Bitmap)MainForm.PictureList[TabNum].Image;
            Bitmap newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height, PixelFormat.Format24bppRgb);
            for (int x = 0; x < MainForm.PictureList[TabNum].Width; x++)
            {
                for (int y = 0; y < MainForm.PictureList[TabNum].Height; y++)
                {
                    Color pixel = oldBitmap.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(LUTred[pixel.R], LUTgreen[pixel.G], LUTblue[pixel.B]);
                    newBitmap.SetPixel(x, y, newPixel);
                    Red[newPixel.R]++;
                    Green[newPixel.G]++;
                    Blue[newPixel.B]++;
                }
            }
            MainForm.PictureList[TabNum].Image = newBitmap;

            histogramChartMono.Series["red"].Points.Clear();
            histogramChartMono.Series["green"].Points.Clear();
            histogramChartMono.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                histogramChartMono.Series["red"].Points.AddXY(i, Red[i]);
                histogramChartMono.Series["green"].Points.AddXY(i, Green[i]);
                histogramChartMono.Series["blue"].Points.AddXY(i, Blue[i]);
            }
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();
            histogramChartMono.Invalidate();
        }
    }
}
