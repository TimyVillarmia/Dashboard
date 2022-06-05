using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.UserControls
{
    public partial class SignUpUC : UserControl
    {

        private static SignUpUC _instance;
        static Regex validate_emailaddress = Email_Validation();

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

        private static Regex Email_Validation()
        {
            string pattern = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";
            return new Regex(pattern, RegexOptions.IgnoreCase);

        }


        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UserControls.SignUpUC.Instance.SendToBack();

        }

        private void togglePass_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPass.PasswordChar = '•';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                txtConfirmPass.BorderColor = Color.FromArgb(0, 128, 0);
                txtPassword.BorderColor = Color.FromArgb(0, 128, 0);



            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                txtConfirmPass.BorderColor = Color.FromArgb(0, 128, 0);
                txtPassword.BorderColor = Color.FromArgb(0, 128, 0);


            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                txtEmail.BorderColor = Color.FromArgb(0, 128, 0);

            }
            else
            {
                txtEmail.BorderColor = Color.FromArgb(255, 0, 0);

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty)
            {
                txtUsername.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtUsername.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {


        }
    }

} 
    
