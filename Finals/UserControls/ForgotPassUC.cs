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
    public partial class ForgotPassUC : UserControl
    {

        private static ForgotPassUC _instance;
        public static ForgotPassUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ForgotPassUC();
                return _instance;
            }
        }
        public ForgotPassUC()
        {
            InitializeComponent();
        }
        public void OTP_generator()
        {
            var otp_char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                OTP += random_char;
                
            }

        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserControls.ForgotPassUC.Instance.SendToBack();

        }

       
    }
}
