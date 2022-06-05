namespace Finals.UserControls
{
    partial class ForgotPassUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelForgotPass = new Guna.UI2.WinForms.Guna2Panel();
            this.SignInPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOTPsend = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.txtOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRecover = new Guna.UI2.WinForms.Guna2Button();
            this.panelForgotPass.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForgotPass
            // 
            this.panelForgotPass.Controls.Add(this.SignInPanel);
            this.panelForgotPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForgotPass.Location = new System.Drawing.Point(0, 0);
            this.panelForgotPass.Name = "panelForgotPass";
            this.panelForgotPass.Size = new System.Drawing.Size(1000, 700);
            this.panelForgotPass.TabIndex = 5;
            // 
            // SignInPanel
            // 
            this.SignInPanel.BorderRadius = 18;
            this.SignInPanel.Controls.Add(this.txtConfirmNewPass);
            this.SignInPanel.Controls.Add(this.btnOTPsend);
            this.SignInPanel.Controls.Add(this.txtEmail);
            this.SignInPanel.Controls.Add(this.txtNewPass);
            this.SignInPanel.Controls.Add(this.linkSignIn);
            this.SignInPanel.Controls.Add(this.txtOTP);
            this.SignInPanel.Controls.Add(this.btnRecover);
            this.SignInPanel.Location = new System.Drawing.Point(293, 75);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(414, 550);
            this.SignInPanel.TabIndex = 5;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmNewPass.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmNewPass.BorderRadius = 12;
            this.txtConfirmNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmNewPass.DefaultText = "";
            this.txtConfirmNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtConfirmNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmNewPass.Location = new System.Drawing.Point(40, 312);
            this.txtConfirmNewPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '•';
            this.txtConfirmNewPass.PlaceholderText = "New Password";
            this.txtConfirmNewPass.SelectedText = "";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(343, 49);
            this.txtConfirmNewPass.TabIndex = 17;
            // 
            // btnOTPsend
            // 
            this.btnOTPsend.BorderRadius = 12;
            this.btnOTPsend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOTPsend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOTPsend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOTPsend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOTPsend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnOTPsend.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTPsend.ForeColor = System.Drawing.Color.White;
            this.btnOTPsend.Location = new System.Drawing.Point(255, 193);
            this.btnOTPsend.Name = "btnOTPsend";
            this.btnOTPsend.Size = new System.Drawing.Size(128, 50);
            this.btnOTPsend.TabIndex = 16;
            this.btnOTPsend.Text = "Send OTP";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Enter Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(343, 49);
            this.txtEmail.TabIndex = 15;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BorderColor = System.Drawing.Color.Black;
            this.txtNewPass.BorderRadius = 12;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Location = new System.Drawing.Point(40, 253);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '•';
            this.txtNewPass.PlaceholderText = "New Password";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(343, 49);
            this.txtNewPass.TabIndex = 9;
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignIn.LinkColor = System.Drawing.Color.Black;
            this.linkSignIn.Location = new System.Drawing.Point(339, 518);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(44, 19);
            this.linkSignIn.TabIndex = 8;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Back";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.Transparent;
            this.txtOTP.BorderColor = System.Drawing.Color.Black;
            this.txtOTP.BorderRadius = 12;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.DefaultText = "";
            this.txtOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOTP.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtOTP.ForeColor = System.Drawing.Color.Black;
            this.txtOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOTP.Location = new System.Drawing.Point(40, 194);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.PasswordChar = '•';
            this.txtOTP.PlaceholderText = "Enter OTP";
            this.txtOTP.SelectedText = "";
            this.txtOTP.Size = new System.Drawing.Size(207, 49);
            this.txtOTP.TabIndex = 2;
            // 
            // btnRecover
            // 
            this.btnRecover.BorderRadius = 12;
            this.btnRecover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnRecover.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.Location = new System.Drawing.Point(40, 369);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(343, 50);
            this.btnRecover.TabIndex = 7;
            this.btnRecover.Text = "Recover Account";
            // 
            // ForgotPassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelForgotPass);
            this.Name = "ForgotPassUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.panelForgotPass.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelForgotPass;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SignInPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmNewPass;
        private Guna.UI2.WinForms.Guna2Button btnOTPsend;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private Guna.UI2.WinForms.Guna2TextBox txtOTP;
        private Guna.UI2.WinForms.Guna2Button btnRecover;
    }
}
