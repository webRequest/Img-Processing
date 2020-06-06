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
    public partial class SaveForm : Form
    {
        TabControl tabControl;
        List<PictureBox> pictureList;
        public SaveForm(TabControl tabCtrl, List<PictureBox> pctList)
        {
            tabControl = tabCtrl;
            pictureList = pctList;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "(*.jpg;*.gif;*.png;*.bmp)|*.jpg;*.gif;*.png;*.bmp";
            fileDialog.AddExtension = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = pictureList[tabControl.SelectedIndex].Image;
                img.Save(fileDialog.FileName);
            }
            fileDialog.Dispose();
            pictureList.Remove(pictureList[tabControl.SelectedIndex]);
            tabControl.TabPages.Remove(tabControl.SelectedTab);
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            pictureList.Remove(pictureList[tabControl.SelectedIndex]);
            tabControl.TabPages.Remove(tabControl.SelectedTab);
            Close();
        }
    }
}
