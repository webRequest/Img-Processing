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
    public partial class WspolczynnikiKsztaltuForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public WspolczynnikiKsztaltuForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            InitializeComponent();
            tabControl = tabCtrl;
            pictureList = pctList;
            Initialize();
        }

        public void Initialize()
        {
            long x = 1, y = 1, z = 1;
            var list1 = IPALibrary.AspectRatio(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list1)
            {
                listBox1.Items.Add($"Obiekt {x++}:  " + item);
            }

            var list2 = IPALibrary.Extend(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list2)
            {
                listBox2.Items.Add($"Obiekt {y++}:  " + item);
            }

            var list3 = IPALibrary.EquivalentDiameter(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list3)
            {
                listBox3.Items.Add($"Obiekt {z++}:  " + item);
            }
        }
    }
}
