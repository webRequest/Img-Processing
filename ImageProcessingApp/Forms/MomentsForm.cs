using ImageProcessingApp.Library;
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
    public partial class Moments : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public Moments(TabControl tabCtrl, List<PictureBox> pctList)
        {
            InitializeComponent();
            tabControl = tabCtrl;
            pictureList = pctList;
            Initialize();
        }

        public void Initialize()
        {
            var list = IPALibrary.Moments(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
