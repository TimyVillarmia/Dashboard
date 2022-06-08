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
      
        public HomeUC()
        {
            InitializeComponent();
           
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Controls.Add(ModeUC.Instance);
            ModeUC.Instance.BringToFront();
        }

  
    }
}
