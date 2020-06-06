using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ImageProcessingApp.Library
{
    public class IPALibrary
    {
        public static bool IsMonochromatic(Bitmap picture)
        {
            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    Color pixel = picture.GetPixel(x, y);
                    if (!(pixel.R == pixel.G && pixel.R == pixel.B))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int[] CalculateLUT(int[] values)
        {
            int minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = i;
                    break;
                }
            }

            int maxValue = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (values[i] != 0)
                {
                    maxValue = i;
                    break;
                }
            }

            int[] result = new int[256];
            double a = 255.0 / (maxValue - minValue);
            for (int i = 0; i < 256; i++)
            {
                result[i] = (int)(a * (i - minValue));
            }

            return result;
        }

        public static int[] CalculateLUTForEqualization(int[] values, int size)
        {
            double minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = values[i];
                    break;
                }
            }

            int[] result = new int[256];
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += values[i];
                result[i] = (int)(((sum - minValue) / (size - minValue)) * 255.0);
            }

            return result;
        }

        public static void Negation(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
            byte[] pixelValues = new byte[Math.Abs(bitmapData.Stride) * picture.Height];
            System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, pixelValues, 0, pixelValues.Length);

            for (int i = 0; i < pixelValues.Length; i++)
            {
                pixelValues[i] = (byte)(255 - pixelValues[i]);
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, bitmapData.Scan0, pixelValues.Length);
            bitmap.UnlockBits(bitmapData);
            picture.Refresh();
        }

        //
        // EMGU
        //

        public static void Erode(PictureBox picture, Emgu.CV.CvEnum.BorderType type, Emgu.CV.CvEnum.ElementShape shape)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(5, 5), new Point(-1, -1));
            var img = bitmap.ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Erode(img, imgDst, kernel, new Point(-1, -1), 2, type, new MCvScalar(1.0));
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }
        public static void Dilate(PictureBox picture, Emgu.CV.CvEnum.BorderType type, Emgu.CV.CvEnum.ElementShape shape)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(5, 5), new Point(-1, -1));
            var img = bitmap.ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Dilate(img, imgDst, kernel, new Point(-1, -1), 2, type, new MCvScalar(1.0));
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }
        public static void Open(PictureBox picture, Emgu.CV.CvEnum.BorderType type, Emgu.CV.CvEnum.ElementShape shape)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(5, 5), new Point(-1, -1));
            var img = bitmap.ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.MorphologyEx(img, imgDst, Emgu.CV.CvEnum.MorphOp.Open, kernel, new Point(-1, -1), 2, type, new MCvScalar(1.0));
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }
        public static void Close(PictureBox picture, Emgu.CV.CvEnum.BorderType type, Emgu.CV.CvEnum.ElementShape shape)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(5, 5), new Point(-1, -1));
            var img = bitmap.ToImage<Bgr, byte>();
            var imgDst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.MorphologyEx(img, imgDst, Emgu.CV.CvEnum.MorphOp.Close, kernel, new Point(-1, -1), 2, type, new MCvScalar(1.0));
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }

        public static void Skeletonization(PictureBox picture, Emgu.CV.CvEnum.BorderType type, Emgu.CV.CvEnum.ElementShape shape)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(3, 3), new Point(-1, -1));

            var original = bitmap.ToImage<Gray, byte>();
            var skel = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            var imgCopy = bitmap.ToImage<Gray, byte>();

            while (true)
            {
                var imgOpen = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
                Emgu.CV.CvInvoke.MorphologyEx(imgCopy, imgOpen, Emgu.CV.CvEnum.MorphOp.Open, kernel, new Point(-1, -1), 1, type, new MCvScalar(1.0));
                var imgTemp = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
                Emgu.CV.CvInvoke.Subtract(imgCopy, imgOpen, imgTemp);
                var imgEroded = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
                Emgu.CV.CvInvoke.Erode(imgCopy, imgEroded, kernel, new Point(-1, -1), 1, type, new MCvScalar(1.0));
                Emgu.CV.CvInvoke.BitwiseOr(skel, imgTemp, skel);
                imgCopy = imgEroded;
                if (Emgu.CV.CvInvoke.CountNonZero(imgCopy) == 0)
                {
                    break;
                }
            }

            picture.Image = skel.ToBitmap();
            GC.Collect();
        }
        public static void FiltracjaJednoetapowa(PictureBox picture, Emgu.CV.CvEnum.BorderType type)
        {
            var mask = new float[,] 
            { 
                {1, -1, 0, -1, 1},
                { -1, 1, 0, 1, -1},
                { 0, 0, 0, 0, 0},
                { -1, 1, 0, 1, -1},
                { 1, -1, 0, -1, 1} 
            };
            ConvolutionKernelF kernel = new ConvolutionKernelF(mask);
            Bitmap bitmap = (Bitmap)picture.Image;

            var img = bitmap.ToImage<Bgr, byte>();

            var imgDst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgDst, kernel, new Point(-1, -1), 0, type);
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }

        public static void FiltracjaDwuetapowa(PictureBox picture, Emgu.CV.CvEnum.BorderType type)
        {
            var maskWygladzanie = new float[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var maskWyostrzanie = new float[,] { { 1, -2, 1 }, { -2, 4, -2 }, { 1, -2, 1 } };

            ConvolutionKernelF kernelWygladzanie = new ConvolutionKernelF(maskWygladzanie);
            ConvolutionKernelF kernelWyostrzanie = new ConvolutionKernelF(maskWyostrzanie);
            Bitmap bitmap = (Bitmap)picture.Image;

            var img = bitmap.ToImage<Bgr, byte>();

            var imgRes1 = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(img, imgRes1, kernelWygladzanie, new Point(-1, -1), 0, type);

            var imgRes2 = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.Filter2D(imgRes1, imgRes2, kernelWyostrzanie, new Point(-1, -1), 0, type);
            picture.Image = imgRes2.ToBitmap();
            GC.Collect();
        }

        public static void ProgowanieAdaptacyjne(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();
            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));

            Emgu.CV.CvInvoke.AdaptiveThreshold(img, imgDst, 255, adaptiveType: Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC,
                thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary, 11, 5);
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }

        public static void ProgowanieOtsu(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();
            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));

            Emgu.CV.CvInvoke.Threshold(img, imgDst, 0, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Otsu);
            picture.Image = imgDst.ToBitmap();
            GC.Collect();
        }

        public static List<string> Moments(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();
            Moments m = Emgu.CV.CvInvoke.Moments(img);

            List<string> moments = new List<string>();
            moments.Add("m00: " + m.M00);
            moments.Add("m01: " + m.M01);
            moments.Add("m02: " + m.M02);
            moments.Add("m03: " + m.M03);
            moments.Add("m10: " + m.M10);
            moments.Add("m11: " + m.M11);
            moments.Add("m12: " + m.M12);
            moments.Add("m20: " + m.M20);
            moments.Add("m21: " + m.M21);
            moments.Add("m30: " + m.M30);
            moments.Add("mu02: " + m.Mu02);
            moments.Add("mu03: " + m.Mu03);
            moments.Add("mu11: " + m.Mu11);
            moments.Add("mu12: " + m.Mu12);
            moments.Add("mu20: " + m.Mu20);
            moments.Add("mu21: " + m.Mu21);
            moments.Add("mu30: " + m.Mu30);
            moments.Add("nu02: " + m.Nu02);
            moments.Add("nu03: " + m.Nu03);
            moments.Add("nu11: " + m.Nu11);
            moments.Add("nu12: " + m.Nu12);
            moments.Add("nu20: " + m.Nu20);
            moments.Add("nu21: " + m.Nu21);
            moments.Add("nu30: " + m.Nu30);

            return moments;
        }
        public static List<string> AspectRatio(PictureBox picture)
        {
            List<string> AspectList = new List<string>();
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < cont.Size; i++)
            {
                var x = Emgu.CV.CvInvoke.BoundingRectangle(cont[i]);
                double aspectR = (double)x.Width / x.Height;
                AspectList.Add(Convert.ToString(aspectR));
            }
            return AspectList;
        }

        public static List<string> Extend(PictureBox picture)
        {
            List<string> ContList = ContoursArea(picture);
            List<string> ExtList = new List<string>();
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < cont.Size; i++)
            {
                var x = Emgu.CV.CvInvoke.BoundingRectangle(cont[i]);
                double rectArea = (double)x.Width * x.Height;
                double ext = Convert.ToDouble(ContList[i]) / rectArea;
                ExtList.Add(Convert.ToString(ext));
            }
            return ExtList;
        }

        public static List<string> EquivalentDiameter(PictureBox picture)
        {
            List<string> ContList = ContoursArea(picture);
            List<string> DiamList = new List<string>();
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < cont.Size; i++)
            {
                var area = Emgu.CV.CvInvoke.ContourArea(cont[i]);
                double diam = Math.Sqrt((4 * area) / Math.PI);
                DiamList.Add(Convert.ToString(diam));
            }
            return DiamList;
        }

        public static List<string> ContoursArea(PictureBox picture)
        {
            List<string> ContList = new List<string>();
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < cont.Size; i++)
            {
                ContList.Add(Convert.ToString(Math.Round(Emgu.CV.CvInvoke.ContourArea(cont[i]), 3)));
            }

            return ContList;
        }

        public static List<string> ContoursCircuit(PictureBox picture)
        {
            List<string> CircuitsList = new List<string>();
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < cont.Size; i++)
            {
                CircuitsList.Add(Convert.ToString(Math.Round(Emgu.CV.CvInvoke.ArcLength(cont[i], true), 3)));
            }

            return CircuitsList;
        }

        public static void DrawContours(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();

            var imgDst = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDst, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);
            Emgu.CV.Util.VectorOfVectorOfPoint cont = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();
            Emgu.CV.CvInvoke.FindContours(imgDst, cont, hier, mode: Emgu.CV.CvEnum.RetrType.List, method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            var dst = new Image<Bgr, byte>(picture.Width, picture.Height, new Bgr(0, 0, 0));
            Emgu.CV.CvInvoke.CvtColor(img, dst, code: Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);

            List<MCvScalar> scalarList = new List<MCvScalar>();
            scalarList.Add(new MCvScalar(255, 0, 0));
            scalarList.Add(new MCvScalar(0, 255, 0));
            scalarList.Add(new MCvScalar(0, 0, 255));
            scalarList.Add(new MCvScalar(255, 255, 0));
            int x = 0;
            for (int i = 0; i < cont.Size; i++)
            {
                Emgu.CV.CvInvoke.DrawContours(dst, cont, i, scalarList[x++], 2);
                if (x >= 3)
                {
                    x = 0;
                }
            }
            picture.Image = dst.ToBitmap();
            GC.Collect();
        }

        public static void Watershed(PictureBox picture)
        {
            Bitmap bitmap = (Bitmap)picture.Image;
            var img = bitmap.ToImage<Gray, byte>();
            var imgOri = bitmap.ToImage<Bgr, byte>();
            var maskWygladzanie = new float[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            ConvolutionKernelF kernel = new ConvolutionKernelF(maskWygladzanie);
            var imgDstThreshold = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(img, imgDstThreshold, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Otsu);


            var imgDstOpen = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.MorphologyEx(imgDstThreshold, imgDstOpen, Emgu.CV.CvEnum.MorphOp.Open, kernel, new Point(-1, -1), 1, borderType: Emgu.CV.CvEnum.BorderType.Replicate, new MCvScalar(1.0));

            var imgDstDilate = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Dilate(imgDstOpen, imgDstDilate, kernel, new Point(-1, -1), 1, borderType: Emgu.CV.CvEnum.BorderType.Replicate, new MCvScalar(1.0));

            var labels = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            var imgDstTransform = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.DistanceTransform(imgDstOpen, imgDstTransform, labels, distanceType: Emgu.CV.CvEnum.DistType.L2, 5);

            var imgDstT = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Threshold(imgDstT, imgDstThreshold, 127, 255, thresholdType: Emgu.CV.CvEnum.ThresholdType.Binary);


            var sub = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.Subtract(imgDstDilate, imgDstT, sub);

            var markers = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
            Emgu.CV.CvInvoke.ConnectedComponents(imgDstT, markers);

            Emgu.CV.CvInvoke.Watershed(imgOri, markers);

            picture.Image = markers.ToBitmap();
        }
    }
}
