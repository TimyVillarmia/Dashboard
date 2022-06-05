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
    public partial class SignUpUC : UserControl
    {

        private static SignUpUC _instance;
        public static SignUpUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SignUpUC();
                return _instance;
            }
        }
        public SignUpUC()
        {
            InitializeComponent();
        }


        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            UserControls.SignUpUC.Instance.SendToBack();

        }
    }
}
