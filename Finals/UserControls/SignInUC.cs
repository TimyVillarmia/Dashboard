using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Finals.UserControls
{
    public partial class SignInUC : UserControl
    {

        private static SignInUC _instance;
        public static SignInUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SignInUC();
                return _instance;
            }
        } 
        public SignInUC()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = false;
        }

        private void SignInUC_Load(object sender, EventArgs e)
        {
            
        }



        private void linkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserControls.SignInUC.Instance.SendToBack();

            //if (!PanelSignIn.Controls.Contains(UserControls.SignInUC.Instance))
            //{
            //    Controls.Add(UserControls.SignUpUC.Instance);
            //    UserControls.SignUpUC.Instance.BringToFront();
            //}
            //else
            //    UserControls.SignUpUC.Instance.BringToFront();
        }

        private void togglePass_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!PanelSignIn.Controls.Contains(UserControls.ForgotPassUC.Instance))
            {
                Controls.Add(UserControls.ForgotPassUC.Instance);
                UserControls.ForgotPassUC.Instance.BringToFront();
            }
            else
                UserControls.ForgotPassUC.Instance.BringToFront();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Incorrect Username");
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("Incorrect Password");
            }
            else if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            else
            {
                MessageBox.Show("Login Successfully");

            }


        }
    }
}
