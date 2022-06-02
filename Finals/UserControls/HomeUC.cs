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
    public partial class HomeUC : UserControl
    {
        private static HomeUC _instance;
        public static HomeUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeUC();
                return _instance;
            }
        }
        public HomeUC()
        {
            InitializeComponent();

        }

 

        private void BtnSIgnIn_Click_1(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(UserControls.SignInUC.Instance))
            {
                HomePanel.Controls.Add(UserControls.SignInUC.Instance);
                UserControls.SignInUC.Instance.Dock = DockStyle.Fill;
                UserControls.SignInUC.Instance.BringToFront();
            }
            else
                UserControls.SignInUC.Instance.BringToFront();
        }
    }
}
