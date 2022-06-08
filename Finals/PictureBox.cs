using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity910_Group2_CS201
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void picbox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One", "Image One");
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two", "Image Two");
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three", "Image Three");
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four", "Image Four");
        }

        private void picbox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five", "Image Five");
        }
    }
}
