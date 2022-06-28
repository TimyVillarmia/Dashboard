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

        public static string RegisteredUsername;
        public static bool ADMIN;
        string RecoverEmail;
        public static string RegisteredEmail;
        string RegisteredPassword;
        string OTP;

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
                    ADMIN = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Login Successfully");
                    ParentForm.Hide();
                    DASHBOARD dashboard = new DASHBOARD();
                    dashboard.ShowDialog();
                    ParentForm.Close();

             

                }
                else if (txtUsername.Text == RegisteredUsername && txtPassword.Text == RegisteredPassword)
                {
                    ADMIN = false;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Login Successfully");
                    ParentForm.Hide();
                    DASHBOARD dashboard = new DASHBOARD();
                    dashboard.ShowDialog();
                    ParentForm.Close();
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

                    ForgotPassPanel.Visible = false;
                    SignInPanel.Visible = true;
                    SignUpPanel.Visible = false;

                    txtRegisterEmail.Text = string.Empty;
                    txtRegisterUsername.Text = string.Empty;
                    txtRegisterPassword.Text = string.Empty;
                    txtConfirmPass.Text = string.Empty;
                    checkboxTerms.Checked = false;

                    txtRegisterEmail.BorderColor = Color.FromArgb(0, 0, 0);
                    txtRegisterUsername.BorderColor = Color.FromArgb(0, 0, 0);
                    txtRegisterPassword.BorderColor = Color.FromArgb(0, 0, 0);
                    txtConfirmPass.BorderColor = Color.FromArgb(0, 0, 0);


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
               if (txtRegisterUsername.Text.Length >= 8)
                {
                    txtRegisterUsername.BorderColor = Color.FromArgb(0, 128, 0);
                }
               else
                {
                    txtRegisterUsername.BorderColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                txtRegisterUsername.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text != string.Empty)
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
            else
            {
                txtRegisterPassword.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text != string.Empty)
            {
                if (txtRegisterPassword.Text.Length >= 8)
                {
                    if (txtConfirmPass.Text == txtRegisterPassword.Text)
                    {
                        txtConfirmPass.BorderColor = Color.FromArgb(0, 128, 0);

                    }
                    else
                    {
                        txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);
                    }
                }
                else
                {
                    txtConfirmPass.BorderColor = Color.FromArgb(255, 0, 0);

                }
              

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
            if (RecoverEmail == RegisteredEmail)
            {
                txtRecoverEmail.BorderColor = Color.FromArgb(0, 128, 0);
                //OTP generator
                string otp_char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                OTP = "";
                Random rnd = new Random();

                for (int i = 0; i < 6; i++)
                {
                    var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                    OTP += random_char;

                }

                //initialize variables
                string msg = OTP;
                string senderEmail, senderPass, receiverEmail;
                receiverEmail = txtRecoverEmail.Text;
                senderEmail = "Change this to your sender's email ";
                senderPass = "Change this to your Gmail's App Password";  //Gmail's App Password


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
                    MessageBox.Show("Kindly check your email and don't forget to check your SPAM folders");
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
            else
            {
                MessageBox.Show("Email is not registered");
                txtRecoverEmail.BorderColor = Color.FromArgb(255, 0, 0);
            }

            
        }

        private void toggleForgotPass_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleForgotPass.Checked)
            {
                txtNewPass.PasswordChar = '\0';
                txtConfirmNewPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '•';
                txtConfirmNewPass.PasswordChar = '•';
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (txtRecoverEmail.Text != string.Empty && txtNewPass.Text != string.Empty && txtConfirmNewPass.Text != string.Empty && txtOTP.Text != string.Empty)
            {
                if (txtOTP.Text == OTP)
                {
                    if (txtNewPass.Text == txtConfirmNewPass.Text)
                    {
                        if (txtNewPass.Text.Length >= 8)
                        {
                            RegisteredPassword = txtNewPass.Text;
                            MessageBox.Show("Account recovered successfully");
                            ForgotPassPanel.Visible = false;
                            SignInPanel.Visible = true;
                            SignUpPanel.Visible = false;

                            txtRecoverEmail.Text = string.Empty;
                            txtOTP.Text = string.Empty;
                            txtNewPass.Text = string.Empty;
                            txtConfirmNewPass.Text = string.Empty;

                            txtRecoverEmail.BorderColor = Color.FromArgb(0, 0, 0);
                            txtOTP.BorderColor = Color.FromArgb(0, 0, 0);
                            txtNewPass.BorderColor = Color.FromArgb(0, 0, 0);
                            txtConfirmNewPass.BorderColor = Color.FromArgb(0, 0, 0);


                        }
                        else
                        {
                            MessageBox.Show("Make sure your password is at least 8 characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password are not identical");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid OTP");
                }   
            }
            else
            {
                MessageBox.Show("Make sure you correctly fill up the form");
            }

            

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            RecoverEmail = txtRecoverEmail.Text;

            if (txtRecoverEmail.Text != string.Empty)
            {
                txtRecoverEmail.BorderColor = Color.FromArgb(0, 128, 0);

            }
            else
            {
                txtRecoverEmail.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP.Text != string.Empty)
            {
                if(txtOTP.Text == OTP)
                {
                    txtOTP.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    txtOTP.BorderColor = Color.FromArgb(255, 0, 0);
                    MessageBox.Show("Make sure you entered the correct OTP");
                }

            }
            else
            {
                txtOTP.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != string.Empty)
            {
                if (txtNewPass.Text.Length >= 8)
                {
                    txtNewPass.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    txtNewPass.BorderColor = Color.FromArgb(255, 0, 0);

                }
            }
            else
            {
                txtNewPass.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmNewPass.Text != string.Empty)
            {
                if (txtNewPass.Text.Length >= 8)
                {
                    if (txtNewPass.Text == txtConfirmNewPass.Text)
                    {
                        txtConfirmNewPass.BorderColor = Color.FromArgb(0, 128, 0);
                    }
                    else
                    {
                        txtConfirmNewPass.BorderColor = Color.FromArgb(255, 0, 0);
                    }
                }
                else
                {
                    txtConfirmNewPass.BorderColor = Color.FromArgb(255, 0, 0);
                }


            }
            else
            {
                txtConfirmNewPass.BorderColor = Color.FromArgb(255, 0, 0);
            }


        }
    }
}
