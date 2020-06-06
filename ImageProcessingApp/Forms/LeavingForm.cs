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
    public partial class LeavingForm : Form
    {
        public bool cls = false;
        public LeavingForm()
        {
            InitializeComponent();
            ShowDialog();      
        }

        private void Nie_Click(object sender, EventArgs e)
        {
            cls = false;
            Close();
        }

        private void Tak_Click(object sender, EventArgs e)
        {
            cls = true;
            Close();
        }
    }
}
