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
    public partial class Mode : UserControl
    {

        private static Mode _instance;
        public static Mode Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Mode();
                return _instance;
            }
        }
        public Mode()
        {
            InitializeComponent();

            ModePanel.Controls.Add(UserControls.SignInUC.Instance);
            UserControls.SignInUC.Instance.Dock = DockStyle.Fill;
            UserControls.SignInUC.Instance.BringToFront();
        }







    }
}
