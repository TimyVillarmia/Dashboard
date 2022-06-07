namespace Finals.UserControls
{
    partial class ModeUC
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
            this.togglePass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.picHello = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUpPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtRegisterUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.togglePassCreate = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.checkboxTerms = new System.Windows.Forms.CheckBox();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisterEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.txtRegisterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.ForgotPassPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOTPsend = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRecover = new Guna.UI2.WinForms.Guna2Button();
            this.PanelSignIn.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHello)).BeginInit();
            this.SignUpPanel.SuspendLayout();
            this.ForgotPassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSignIn
            // 
            this.PanelSignIn.Controls.Add(this.SignInPanel);
            this.PanelSignIn.Controls.Add(this.SignUpPanel);
            this.PanelSignIn.Controls.Add(this.ForgotPassPanel);
            this.PanelSignIn.Location = new System.Drawing.Point(0, 0);
            this.PanelSignIn.Name = "PanelSignIn";
            this.PanelSignIn.Size = new System.Drawing.Size(1000, 700);
            this.PanelSignIn.TabIndex = 0;
            // 
            // SignInPanel
            // 
            this.SignInPanel.BorderRadius = 18;
            this.SignInPanel.Controls.Add(this.togglePass);
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
            // togglePass
            // 
            this.togglePass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePass.Location = new System.Drawing.Point(336, 345);
            this.togglePass.Name = "togglePass";
            this.togglePass.Size = new System.Drawing.Size(35, 20);
            this.togglePass.TabIndex = 9;
            this.togglePass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePass.CheckedChanged += new System.EventHandler(this.togglePass_CheckedChanged);
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkColor = System.Drawing.Color.Black;
            this.linkSignUp.Location = new System.Drawing.Point(85, 468);
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
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            this.linkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPass_LinkClicked);
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
            // SignUpPanel
            // 
            this.SignUpPanel.BorderRadius = 18;
            this.SignUpPanel.Controls.Add(this.txtRegisterUsername);
            this.SignUpPanel.Controls.Add(this.togglePassCreate);
            this.SignUpPanel.Controls.Add(this.lblNote);
            this.SignUpPanel.Controls.Add(this.lblCreate);
            this.SignUpPanel.Controls.Add(this.checkboxTerms);
            this.SignUpPanel.Controls.Add(this.txtConfirmPass);
            this.SignUpPanel.Controls.Add(this.txtRegisterEmail);
            this.SignUpPanel.Controls.Add(this.linkSignIn);
            this.SignUpPanel.Controls.Add(this.txtRegisterPassword);
            this.SignUpPanel.Controls.Add(this.btnSignUp);
            this.SignUpPanel.Location = new System.Drawing.Point(293, 75);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(414, 550);
            this.SignUpPanel.TabIndex = 10;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtRegisterUsername.BorderColor = System.Drawing.Color.Black;
            this.txtRegisterUsername.BorderRadius = 12;
            this.txtRegisterUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterUsername.DefaultText = "";
            this.txtRegisterUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisterUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisterUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterUsername.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtRegisterUsername.ForeColor = System.Drawing.Color.Black;
            this.txtRegisterUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterUsername.Location = new System.Drawing.Point(40, 211);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.PasswordChar = '\0';
            this.txtRegisterUsername.PlaceholderText = "Create Username";
            this.txtRegisterUsername.SelectedText = "";
            this.txtRegisterUsername.Size = new System.Drawing.Size(343, 49);
            this.txtRegisterUsername.TabIndex = 15;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // togglePassCreate
            // 
            this.togglePassCreate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePassCreate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePassCreate.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePassCreate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePassCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePassCreate.Location = new System.Drawing.Point(335, 285);
            this.togglePassCreate.Name = "togglePassCreate";
            this.togglePassCreate.Size = new System.Drawing.Size(35, 20);
            this.togglePassCreate.TabIndex = 10;
            this.togglePassCreate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePassCreate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePassCreate.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePassCreate.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePassCreate.CheckedChanged += new System.EventHandler(this.togglePassCreate_CheckedChanged);
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new System.Drawing.Point(41, 71);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(343, 58);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Please fill up the neccessary information to create your account";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Roboto Black", 28F, System.Drawing.FontStyle.Bold);
            this.lblCreate.Location = new System.Drawing.Point(49, 18);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(329, 46);
            this.lblCreate.TabIndex = 13;
            this.lblCreate.Text = "Create an account";
            // 
            // checkboxTerms
            // 
            this.checkboxTerms.AutoSize = true;
            this.checkboxTerms.Location = new System.Drawing.Point(49, 386);
            this.checkboxTerms.Name = "checkboxTerms";
            this.checkboxTerms.Size = new System.Drawing.Size(219, 17);
            this.checkboxTerms.TabIndex = 10;
            this.checkboxTerms.Text = "I agree to all the Term and Privacy Policy";
            this.checkboxTerms.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPass.BorderRadius = 12;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPass.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(40, 329);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '•';
            this.txtConfirmPass.PlaceholderText = "Create Password";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(343, 49);
            this.txtConfirmPass.TabIndex = 9;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtRegisterEmail.BorderColor = System.Drawing.Color.Black;
            this.txtRegisterEmail.BorderRadius = 12;
            this.txtRegisterEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterEmail.DefaultText = "";
            this.txtRegisterEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisterEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisterEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterEmail.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtRegisterEmail.ForeColor = System.Drawing.Color.Black;
            this.txtRegisterEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterEmail.Location = new System.Drawing.Point(40, 152);
            this.txtRegisterEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.PasswordChar = '\0';
            this.txtRegisterEmail.PlaceholderText = "Enter Email";
            this.txtRegisterEmail.SelectedText = "";
            this.txtRegisterEmail.Size = new System.Drawing.Size(343, 49);
            this.txtRegisterEmail.TabIndex = 1;
            this.txtRegisterEmail.TextChanged += new System.EventHandler(this.txtRegisterEmail_TextChanged);
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignIn.LinkColor = System.Drawing.Color.Black;
            this.linkSignIn.Location = new System.Drawing.Point(89, 468);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(244, 19);
            this.linkSignIn.TabIndex = 8;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Already have an account? Sign In";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtRegisterPassword.BorderColor = System.Drawing.Color.Black;
            this.txtRegisterPassword.BorderRadius = 12;
            this.txtRegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterPassword.DefaultText = "";
            this.txtRegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterPassword.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtRegisterPassword.ForeColor = System.Drawing.Color.Black;
            this.txtRegisterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisterPassword.Location = new System.Drawing.Point(40, 270);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '•';
            this.txtRegisterPassword.PlaceholderText = "Create Password";
            this.txtRegisterPassword.SelectedText = "";
            this.txtRegisterPassword.Size = new System.Drawing.Size(343, 49);
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderRadius = 12;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnSignUp.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(40, 410);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(343, 50);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Create account";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // ForgotPassPanel
            // 
            this.ForgotPassPanel.BorderRadius = 18;
            this.ForgotPassPanel.Controls.Add(this.txtConfirmNewPass);
            this.ForgotPassPanel.Controls.Add(this.btnOTPsend);
            this.ForgotPassPanel.Controls.Add(this.txtEmail);
            this.ForgotPassPanel.Controls.Add(this.txtNewPass);
            this.ForgotPassPanel.Controls.Add(this.linkLabel1);
            this.ForgotPassPanel.Controls.Add(this.txtOTP);
            this.ForgotPassPanel.Controls.Add(this.btnRecover);
            this.ForgotPassPanel.Location = new System.Drawing.Point(293, 75);
            this.ForgotPassPanel.Name = "ForgotPassPanel";
            this.ForgotPassPanel.Size = new System.Drawing.Size(414, 550);
            this.ForgotPassPanel.TabIndex = 11;
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
            this.btnOTPsend.Click += new System.EventHandler(this.btnOTPsend_Click);
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(339, 518);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // ModeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelSignIn);
            this.Name = "ModeUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.SignInUC_Load);
            this.PanelSignIn.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHello)).EndInit();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.ForgotPassPanel.ResumeLayout(false);
            this.ForgotPassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelSignIn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SignInPanel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togglePass;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Label lblHello;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2PictureBox picHello;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblAlt;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SignUpPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterUsername;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togglePassCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.CheckBox checkboxTerms;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterEmail;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ForgotPassPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmNewPass;
        private Guna.UI2.WinForms.Guna2Button btnOTPsend;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtOTP;
        private Guna.UI2.WinForms.Guna2Button btnRecover;
    }
}
