using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.UserControls.SignMode
{
    public partial class ForgotPass : UserControl
    {
        public ForgotPass()
        {
            InitializeComponent();
        }


        private void goBack_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signInForm.BringToFront();
        }
    }
}
