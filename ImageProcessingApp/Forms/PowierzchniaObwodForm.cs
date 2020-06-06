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
    public partial class PowierzchniaObwodForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public PowierzchniaObwodForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            InitializeComponent();
            tabControl = tabCtrl;
            pictureList = pctList;
            Initialize();
        }

        public void Initialize()
        {
            long x = 1, y = 1;
            var list1 = IPALibrary.ContoursArea(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list1)
            {
                listBox1.Items.Add($"Obiekt {x++}:  " + item);
            }

            var list2 = IPALibrary.ContoursCircuit(pictureList[tabControl.SelectedIndex]);
            foreach (var item in list2)
            {
                listBox2.Items.Add($"Obiekt {y++}:  " + item);
            }
        }
    }
}
