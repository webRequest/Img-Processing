using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ImageProcessingApp.Forms;
using ImageProcessingApp.Library;


namespace ImageProcessingApp
{
    public partial class MainForm : Form
    {
        private bool Dragging;
        private int xPos;
        private int yPos;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) { Dragging = false; }
        public static List<PictureBox> PictureList = new List<PictureBox>();
        public static List<HistogramFormRgb> HistogramFormRgbList = new List<HistogramFormRgb>();
        public static List<HistogramFormMono> HistogramFormMonoList = new List<HistogramFormMono>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.jpg;*.gif;*.png;*.bmp)|*.jpg;*.gif;*.png;*.bmp";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = fileDialog.SafeFileName.Substring(0, fileDialog.SafeFileName.LastIndexOf('.'));
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = new Bitmap(fileDialog.OpenFile());
                pictureBox.Height = pictureBox.Image.Height;
                pictureBox.Width = pictureBox.Image.Width;
                pictureBox.Name = name;
                pictureBox.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
                pictureBox.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
                PictureList.Add(pictureBox);
                tabControl1.Name = "DynamicTabControl";
                Controls.Add(tabControl1);

                TabPage tabPage1 = new TabPage();
                tabPage1.Name = "tabPage1";
                tabPage1.Text = name;
                tabPage1.Controls.Add(pictureBox);
                tabControl1.TabPages.Add(tabPage1);
                this.menuItemHisto.Enabled = true;
                this.menuItemTools.Enabled = true;
                this.OperacjeSasiedztwa.Enabled = true;
                this.Morfologia.Enabled = true;
                this.Segmentacja.Enabled = true;
                this.AnalizaObrazu.Enabled = true;
                this.Zapisz.Enabled = true;
            }
            fileDialog.Dispose();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuItemOpn_Click(object sender, EventArgs e)
        {
            Open_Click(sender, e);
        }

        private void menuItemHisto_Click(object sender, EventArgs e)
        {
            if (IPALibrary.IsMonochromatic((Bitmap)PictureList[tabControl1.SelectedIndex].Image))
            {
                HistogramFormMono histogramFormMono = new HistogramFormMono(new int[256], new int[256], new int[256], tabControl1.SelectedIndex);
                HistogramFormMonoList.Add(histogramFormMono);
            }
            else
            {
                HistogramFormRgb histogramFormRgb = new HistogramFormRgb(new int[256], new int[256], new int[256], tabControl1.SelectedIndex);
                HistogramFormRgbList.Add(histogramFormRgb);
            }
        }

        private void Negacja_Click(object sender, EventArgs e)
        {
            IPALibrary.Negation(PictureList[tabControl1.SelectedIndex]);
        }

        private void Progowanie_Click(object sender, EventArgs e)
        {
            ThresholdingForm thresholdingForm = new ThresholdingForm(tabControl1.SelectedIndex);
            thresholdingForm.Show();
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            XorForm xorForm = new XorForm(tabControl1, PictureList);
            xorForm.Show();
        }

        private void OR_Click(object sender, EventArgs e)
        {
            OrForm orForm = new OrForm(tabControl1, PictureList);
            orForm.Show();
        }

        private void AND_Click(object sender, EventArgs e)
        {
            AndForm andForm = new AndForm(tabControl1, PictureList);
            andForm.Show();
        }

        private void Mieszanie_Click(object sender, EventArgs e)
        {
            BlendingForm blendingForm = new BlendingForm(tabControl1, PictureList);
            blendingForm.Show();
        }

        private void Blur_Click(object sender, EventArgs e)
        {
            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width, 
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0,0,0));

            Emgu.CV.CvInvoke.Blur(img, imgDst, new Size(5, 5), new Point(-1, -1), borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void GaussianBlur_Click(object sender, EventArgs e)
        {
            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));

            Emgu.CV.CvInvoke.GaussianBlur(img, imgDst, new Size(5, 5), 0, 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));

            Emgu.CV.CvInvoke.Sobel(img, imgDst, Emgu.CV.CvEnum.DepthType.Cv8U, 1, 0, 3, 1 , 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void Laplacian_Click(object sender, EventArgs e)
        {
            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));

            Emgu.CV.CvInvoke.Laplacian(img, imgDst, Emgu.CV.CvEnum.DepthType.Cv8U, 1, 1, 0);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void Canny_Click(object sender, EventArgs e)
        {
            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));

            Emgu.CV.CvInvoke.Canny(img, imgDst, 100, 200); //NIE DZIALA COS W BIBLIOTECE
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void WLiniowePreset1_Click(object sender, EventArgs e)
        {
            float[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            ConvolutionKernelF kernel = new ConvolutionKernelF(matrix);

            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, -1), 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void WLiniowePreset2_Click(object sender, EventArgs e)
        {
            float[,] matrix = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            ConvolutionKernelF kernel = new ConvolutionKernelF(matrix);

            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, -1), 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void WLiniowePreset3_Click(object sender, EventArgs e)
        {
            float[,] matrix = { { 1, -2, 1 }, { -2, 4, -2 }, { 1, -2, 1 } };
            ConvolutionKernelF kernel = new ConvolutionKernelF(matrix);

            var img = ((Bitmap)PictureList[tabControl1.SelectedIndex].Image).ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(PictureList[tabControl1.SelectedIndex].Image.Width,
                PictureList[tabControl1.SelectedIndex].Image.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, -1), 0, borderType: Emgu.CV.CvEnum.BorderType.Replicate);
            PictureList[tabControl1.SelectedIndex].Image = imgDst.ToBitmap();
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            PrewittForm andForm = new PrewittForm(tabControl1, PictureList);
            andForm.Show();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            OperacjeMedianoweForm andForm = new OperacjeMedianoweForm(tabControl1, PictureList);
            andForm.Show();
        }

        private void ErozjaIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ErozjaReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ErozjaReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void DylatacjaIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void DylatacjaReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void DylatacjaReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void OtwarcieIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void OtwarcieReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void OtwarcieReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ZamkniecieIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ZamkniecieReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ZamkniecieReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void ErozjaIsolatedKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void ErozjaReflectKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void ErozjaReplicateKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Erode(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void DylatacjaIsolatedKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void DylatacjaReflectKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void DylatacjaReplicateKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Dilate(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void OtwarcieIsolatedKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void OtwarcieReflectKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void OtwarcieReplicateKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Open(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void ZamkniecieIsolatedKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void ZamkniecieReflectKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void ZamkniecieReplicateKwadrat_Click(object sender, EventArgs e)
        {
            IPALibrary.Close(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Rectangle);
        }

        private void Szkieletyzacja_Click(object sender, EventArgs e)
        {
            IPALibrary.Skeletonization(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate, Emgu.CV.CvEnum.ElementShape.Cross);
        }

        private void FiltracjaDwuIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated);
        }

        private void FiltracjaDwuReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect);
        }

        private void FiltracjaDwuReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate);
        }

        private void FiltracjaJednoIsolated_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Isolated);
        }

        private void FiltracjaJednoReflect_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Reflect);
        }

        private void FiltracjaJednoReplicate_Click(object sender, EventArgs e)
        {
            IPALibrary.FiltracjaDwuetapowa(PictureList[tabControl1.SelectedIndex], Emgu.CV.CvEnum.BorderType.Replicate);
        }

        private void ProgAdaptacyjne_Click(object sender, EventArgs e)
        {
            IPALibrary.ProgowanieAdaptacyjne(PictureList[tabControl1.SelectedIndex]);
        }

        private void ProgOtsu_Click(object sender, EventArgs e)
        {
            IPALibrary.ProgowanieOtsu(PictureList[tabControl1.SelectedIndex]);
        }

        private void Momenty_Click(object sender, EventArgs e)
        {
            Forms.Moments momentsForm = new Forms.Moments(tabControl1, PictureList);
            momentsForm.Show();
        }

        private void PowerzchniaObwod_Click(object sender, EventArgs e)
        {
            PowierzchniaObwodForm powierzchniaObwodForm = new PowierzchniaObwodForm(tabControl1, PictureList);
            powierzchniaObwodForm.Show();
        }

        private void RysujKontury_Click(object sender, EventArgs e)
        {
            IPALibrary.DrawContours(PictureList[tabControl1.SelectedIndex]);
        }

        private void UniOperLiniowa_Click(object sender, EventArgs e)
        {
            UniOperLiniowaForm uniOperLiniowaForm = new UniOperLiniowaForm(tabControl1, PictureList);
            uniOperLiniowaForm.Show();
        }

        private void ButtonCloseTab_Click(object sender, EventArgs e)
        {
            SaveForm saveForm = new SaveForm(tabControl1, PictureList);
            saveForm.ShowDialog();          
        }

        private void CloseButtonEventRemove(object sender, ControlEventArgs e)
        {
            if (tabControl1.TabPages.Count <= 1)
            {
                this.ButtonCloseTab.Enabled = false;
                this.menuItemHisto.Enabled = false;
                this.menuItemTools.Enabled = false;
                this.OperacjeSasiedztwa.Enabled = false;
                this.Morfologia.Enabled = false;
                this.Segmentacja.Enabled = false;
                this.AnalizaObrazu.Enabled = false;
                this.Zapisz.Enabled = false;
            }
        }

        private void CloseButtonEventAdd(object sender, ControlEventArgs e)
        {
            if (tabControl1.TabPages.Count <= 0)
            {
                this.ButtonCloseTab.Enabled = false;
            }
            else
            {
                this.ButtonCloseTab.Enabled = true;
            }
        }

        private void WspolKsztaltu_Click(object sender, EventArgs e)
        {
            WspolczynnikiKsztaltuForm wspolczynnikiKsztaltuForm = new WspolczynnikiKsztaltuForm(tabControl1, PictureList);
            wspolczynnikiKsztaltuForm.Show();
        }

        private void Wododzialowa_Click(object sender, EventArgs e)
        {
            IPALibrary.Watershed(PictureList[tabControl1.SelectedIndex]);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
        }

        private void Leaving(object sender, FormClosingEventArgs e)
        {
            if (tabControl1.TabPages.Count <= 0)
            {
                return;
            }
            LeavingForm leavingForm = new LeavingForm();
            if (leavingForm.cls)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "(*.jpg;*.gif;*.png;*.bmp)|*.jpg;*.gif;*.png;*.bmp";
            fileDialog.AddExtension = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = PictureList[tabControl1.SelectedIndex].Image;
                img.Save(fileDialog.FileName);
            }
            fileDialog.Dispose();
        }
    }
}
