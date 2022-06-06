using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password are not identical");
            }
    
            else if (txtEmail.Text == string.Empty && txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please complete the form");
            }
            else if (txtPassword.Text == string.Empty && txtConfirmPass.Text == string.Empty)
            {
                MessageBox.Show("Please complete the form");
            }
            else if (checkboxTerms.Checked == false)
            {
                MessageBox.Show("Please check the Terms and Privacy Policy");
            }
            else
            {
                string writeEmail = txtEmail.Text;
                string writeUsername = txtUsername.Text;
                string writePassword = txtPassword.Text;

                StreamWriter sw = new StreamWriter("F:/Visual Studio 2020/repos/orig/1stYr-Finals/Finals/Accounts/Accounts.txt");

                sw.WriteLine("Email: " + writeEmail);
                sw.WriteLine("Username:" + writeUsername);
                sw.WriteLine("Password:" + writePassword);
                sw.Flush();
                sw.Close();




                UserControls.SignUpUC.Instance.SendToBack();
                MessageBox.Show("Account successfully created, Please Sign In");


            }
        }
    }

}

