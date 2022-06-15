using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.UserControls
{
    public partial class PictureBoxUC : UserControl
    {
        public PictureBoxUC()
        {
            InitializeComponent();
        }

        private void btnDisplayForm_Click(object sender, EventArgs e)
        {
            var showPictureBox = new Activity910_Group2_CS201.PictureBox();
            showPictureBox.Show();
        }
    }
}
