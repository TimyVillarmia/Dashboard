namespace Finals.UserControls
{
    partial class SignInUC
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
            this.PanelSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.SignInPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.picHello = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSignIn.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHello)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSignIn
            // 
            this.PanelSignIn.Controls.Add(this.SignInPanel);
            this.PanelSignIn.Location = new System.Drawing.Point(0, 0);
            this.PanelSignIn.Name = "PanelSignIn";
            this.PanelSignIn.Size = new System.Drawing.Size(1000, 700);
            this.PanelSignIn.TabIndex = 0;
            // 
            // SignInPanel
            // 
            this.SignInPanel.BorderRadius = 18;
            this.SignInPanel.Controls.Add(this.linkSignUp);
            this.SignInPanel.Controls.Add(this.lblHello);
            this.SignInPanel.Controls.Add(this.btnSignIn);
            this.SignInPanel.Controls.Add(this.picHello);
            this.SignInPanel.Controls.Add(this.linkForgotPass);
            this.SignInPanel.Controls.Add(this.txtUsername);
            this.SignInPanel.Controls.Add(this.lblAlt);
            this.SignInPanel.Controls.Add(this.txtPassword);
            this.SignInPanel.Location = new System.Drawing.Point(293, 75);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(414, 550);
            this.SignInPanel.TabIndex = 2;
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkColor = System.Drawing.Color.Black;
            this.linkSignUp.Location = new System.Drawing.Point(85, 464);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(258, 19);
            this.linkSignUp.TabIndex = 8;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Don\'t have an account yet? Sign Up";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked_1);
            // 
            // lblHello
            // 
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(27, 45);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(206, 78);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "Hello!";
            this.lblHello.UseMnemonic = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BorderRadius = 12;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnSignIn.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(40, 410);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(343, 50);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            // 
            // picHello
            // 
            this.picHello.FillColor = System.Drawing.Color.Transparent;
            this.picHello.Image = global::Finals.Properties.Resources.casual_life_3d_young_man_using_laptop_and_talking_on_the_phone;
            this.picHello.ImageRotate = 0F;
            this.picHello.Location = new System.Drawing.Point(180, 17);
            this.picHello.Name = "picHello";
            this.picHello.Size = new System.Drawing.Size(231, 192);
            this.picHello.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHello.TabIndex = 3;
            this.picHello.TabStop = false;
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPass.LinkColor = System.Drawing.Color.Black;
            this.linkForgotPass.Location = new System.Drawing.Point(246, 385);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(137, 19);
            this.linkForgotPass.TabIndex = 6;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "Forgot Password?";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 12;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(40, 270);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(343, 49);
            this.txtUsername.TabIndex = 1;
            // 
            // lblAlt
            // 
            this.lblAlt.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblAlt.ForeColor = System.Drawing.Color.Gray;
            this.lblAlt.Location = new System.Drawing.Point(40, 211);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(343, 58);
            this.lblAlt.TabIndex = 5;
            this.lblAlt.Text = "Please enter your email address and password to get sign in to your account";
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 329);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(343, 49);
            this.txtPassword.TabIndex = 2;
            // 
            // SignInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelSignIn);
            this.Name = "SignInUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.SignInUC_Load);
            this.PanelSignIn.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHello)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelSignIn;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private System.Windows.Forms.Label lblAlt;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblHello;
        private Guna.UI2.WinForms.Guna2PictureBox picHello;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SignInPanel;
    }
}
