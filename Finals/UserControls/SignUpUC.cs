using System;
using System.Drawing;
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

