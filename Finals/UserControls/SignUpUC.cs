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

        string registered_email = ""; 
        string registered_username = ""; 
        string registered_password = "";
  




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
            if (txtPassword.Text.Length >= 8) 
            {
                txtPassword.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtPassword.BorderColor = Color.FromArgb(255, 0, 0);
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text && txtPassword.Text.Length >= 8)
            {
                txtConfirmPass.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
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

        public void btnSignUp_Click(object sender, EventArgs e)
        {
         

            if (txtEmail.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPass.Text != string.Empty && checkboxTerms.Checked != false)
            {
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Make sure your password is more than 8 characters");
                }
                else if (txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Make sure your password is identical");

                }
                else if (checkboxTerms.Checked == false)
                {
                    MessageBox.Show("Don't forget to check the Terms and Privacy Policy");

                }
                else
                {
  

                    UserControls.SignUpUC.Instance.SendToBack();
                    MessageBox.Show("Account successfully created, Please Sign In");

                    registered_email = txtEmail.Text;
                    registered_username = txtUsername.Text;
                    registered_password = txtPassword.Text;
                    

                    MessageBox.Show(registered_email);

                    txtEmail.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPass.Text = "";
                    checkboxTerms.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Make sure you correctly fill up the form");
            }

      
        }
    }

}

