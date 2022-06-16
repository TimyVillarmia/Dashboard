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
    public partial class DashboardHome : UserControl
    {
        public DashboardHome()
        {
            InitializeComponent();
        }

        private void DashboardHome_Load(object sender, EventArgs e)
        {

            if (ModeUC.ADMIN == true)
            {
                lblName.Text = "Admin";
                 
            }
            else
            {
                lblName.Text = ModeUC.RegisteredUsername;
            }
        }
    }
}
