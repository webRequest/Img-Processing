using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingApp.Forms
{
    public partial class UniOperLiniowaForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public UniOperLiniowaForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            pictureList = pctList;
            tabControl = tabCtrl;
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                ErrorForm errorForm = new ErrorForm("Macierz nie została wypełniona w całości!");
                return;
            }
            float[,] k = new float[,] { 
                { float.Parse(textBox1.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox3.Text, CultureInfo.InvariantCulture.NumberFormat) },
                { float.Parse(textBox4.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox5.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox6.Text, CultureInfo.InvariantCulture.NumberFormat) },
                { float.Parse(textBox7.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox8.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(textBox9.Text, CultureInfo.InvariantCulture.NumberFormat) }
            };
            ConvolutionKernelF kernel = new ConvolutionKernelF(k);
            var img = ((Bitmap)pictureList[tabControl.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(pictureList[tabControl.SelectedIndex].Image.Width,
                pictureList[tabControl.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, -1), 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            pictureList[tabControl.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }
    }
}
