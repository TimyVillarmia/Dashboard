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
    public partial class TeamUC : UserControl
    {
        private static TeamUC _instance;
        public static TeamUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeamUC();
                return _instance;
            }
        }
        public TeamUC()
        {
            InitializeComponent();
        }

        private void picbox1_MouseHover(object sender, EventArgs e)
        {
            lblName.Text = "Anzel Ybañez";
            lblText.SendToBack();

        }

        private void picbox1_MouseLeave(object sender, EventArgs e)
        {
            lblName.Text = "Our Story";
            lblText.BringToFront();
        }

        private void picbox2_MouseHover(object sender, EventArgs e)
        {
            lblName.Text = "Timy Villarmia";
            lblText.SendToBack();
        }

        private void picbox2_MouseLeave(object sender, EventArgs e)
        {
            lblName.Text = "Our Story";
            lblText.BringToFront();
        }
    }
}
