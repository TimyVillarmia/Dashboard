using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;




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
     

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserControls.ForgotPassUC.Instance.SendToBack();

        }

        private void btnRecover_Click(object sender, EventArgs e)
        {

         
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
