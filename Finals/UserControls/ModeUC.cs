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
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Finals.UserControls
{
    public partial class ModeUC : UserControl
    {

        private static ModeUC _instance;
        public static ModeUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModeUC();
                return _instance;
            }
        }


        public ModeUC()
        {
            InitializeComponent();

       

        }

        private void SignInUC_Load(object sender, EventArgs e)
        {

        }

        string RegisteredEmail;
        string RegisteredUsername;
        string RegisteredPassword;

        private void linkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPanel.Visible = true;
            ForgotPassPanel.Visible = false;
            SignInPanel.Visible = false;

        }
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassPanel.Visible = false;
            SignInPanel.Visible = true;
            SignUpPanel.Visible = false;
        }
        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ForgotPassPanel.Visible = true;
            SignInPanel.Visible = false;
            SignUpPanel.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassPanel.Visible = false;
            SignInPanel.Visible = true;
            SignUpPanel.Visible = false;
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

     

        private void btnSignIn_Click(object sender, EventArgs e)
        {
  

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    MessageBox.Show("Login Successfully");
                }
                else if (txtUsername.Text == RegisteredUsername && txtPassword.Text == RegisteredPassword)
                {
                    MessageBox.Show("Login Successfully");
                }
                else
                {
                    MessageBox.Show("Wrong username and password combination");
                }       
            }
            else
            {
                MessageBox.Show("Make sure you correctly fill up the form");
            }


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtRegisterEmail.Text != string.Empty && txtRegisterUsername.Text != string.Empty && txtRegisterPassword.Text != string.Empty && txtConfirmPass.Text != string.Empty)
            {
                if (txtRegisterPassword.Text.Length < 8)
                {
                    MessageBox.Show("Make sure your password is at least 8 characters");
                }
                else if (txtRegisterPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Make sure your password is identical");

                }
                else if (checkboxTerms.Checked == false)
                {
                    MessageBox.Show("Don't forget to check the Terms and Privacy Policy");
                }
                else
                {
                    MessageBox.Show("Account successfully created, Please Sign In");

                    RegisteredEmail = txtRegisterEmail.Text;
                    RegisteredUsername = txtRegisterUsername.Text;
                    RegisteredPassword = txtRegisterPassword.Text;

                    checkboxTerms.Checked = false;
                    ForgotPassPanel.Visible = false;
                    SignInPanel.Visible = true;
                    SignUpPanel.Visible = false;

                    ModeUC.Instance.SendToBack();
                }
            }
            else
            {
                MessageBox.Show("Make sure you correctly fill up the form");
            }
        }

        private void txtRegisterEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterEmail.Text != string.Empty)
            {
                txtRegisterEmail.BorderColor = Color.FromArgb(0, 128, 0);

            }
            else
            {
                txtRegisterEmail.BorderColor = Color.FromArgb(255, 0, 0);

            }
        }

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterUsername.Text != string.Empty)
            {
                txtRegisterUsername.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtRegisterUsername.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text.Length >= 8)
            {
                txtRegisterPassword.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtRegisterPassword.BorderColor = Color.FromArgb(255, 0, 0);
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text == txtConfirmPass.Text && txtRegisterPassword.Text.Length >= 8)
            {
                txtConfirmPass.BorderColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void togglePassCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePassCreate.Checked)
            {
                txtRegisterPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtRegisterPassword.PasswordChar = '•';
                txtConfirmPass.PasswordChar = '•';
            }
        }

        private void btnOTPsend_Click(object sender, EventArgs e)
        {
            //OTP generator
            var otp_char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                OTP += random_char;

            }

            //initialize variables
            string msg = OTP;
            string senderEmail, senderPass, receiverEmail;
            receiverEmail = txtEmail.Text;
            senderEmail = "timy.villarmiaact2022@gmail.com";
            senderPass = "phnvprgowvivrndk";  //Gmail's App Password


            MimeMessage message = new MimeMessage(); // Creating object for Message
            message.From.Add(new MailboxAddress("CS201DashBoard - OTP", senderEmail)); //Sender's information
            message.To.Add(MailboxAddress.Parse(receiverEmail)); //Receiver's Information

            message.Subject = "One-Time-Password"; //Email's Subject

            //Email's Body
            message.Body = new TextPart("plain") //Plain text
            {
                Text = msg  //MSG = OTP
            };

            SmtpClient client = new SmtpClient(); // allows sending of e-mail notifications using a SMTP server

            try
            {
                client.Connect("smtp.gmail.com", 465, true); //Gmail's smtp server, PORT: 465
                client.Authenticate(senderEmail, senderPass); //Login sender's email and password
                client.Send(message); //
                MessageBox.Show("Kindly check your entered email address and Don't forget to check your SPAM folders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //if errors display message
            }
            finally
            {
                client.Disconnect(true); // always disconnect
                client.Dispose();
            }
        }
    }
}
