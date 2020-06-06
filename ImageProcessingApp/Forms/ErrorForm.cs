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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string error)
        {
            InitializeComponent();
            this.label1.Text = error;
            ShowDialog();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
