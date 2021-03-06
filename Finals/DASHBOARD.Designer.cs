namespace Finals
{
    partial class DASHBOARD
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SideNav = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.btnPictureBox = new Guna.UI2.WinForms.Guna2Button();
            this.btnConverter = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalculator = new Guna.UI2.WinForms.Guna2Button();
            this.btnGroupProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PicLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SideNav.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 18;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.SideNav);
            this.guna2CustomGradientPanel1.Controls.Add(this.TopPanel);
            this.guna2CustomGradientPanel1.Controls.Add(this.MainPanel);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(213)))), ((int)(((byte)(231)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1000, 800);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.Transparent;
            this.SideNav.BorderColor = System.Drawing.Color.Black;
            this.SideNav.Controls.Add(this.linkLogOut);
            this.SideNav.Controls.Add(this.btnPictureBox);
            this.SideNav.Controls.Add(this.btnConverter);
            this.SideNav.Controls.Add(this.btnCalculator);
            this.SideNav.Controls.Add(this.btnGroupProfile);
            this.SideNav.Controls.Add(this.btnDashboard);
            this.SideNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideNav.CustomBorderColor = System.Drawing.Color.Black;
            this.SideNav.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.Location = new System.Drawing.Point(0, 123);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(233, 677);
            this.SideNav.TabIndex = 9;
            // 
            // linkLogOut
            // 
            this.linkLogOut.BackColor = System.Drawing.Color.Transparent;
            this.linkLogOut.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOut.Image = global::Finals.Properties.Resources.icons8_logout_24;
            this.linkLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLogOut.LinkColor = System.Drawing.Color.Black;
            this.linkLogOut.Location = new System.Drawing.Point(147, 638);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(105, 30);
            this.linkLogOut.TabIndex = 22;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "Logout";
            this.linkLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // btnPictureBox
            // 
            this.btnPictureBox.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPictureBox.CustomBorderColor = System.Drawing.Color.Black;
            this.btnPictureBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnPictureBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPictureBox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPictureBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPictureBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPictureBox.FillColor = System.Drawing.Color.Transparent;
            this.btnPictureBox.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btnPictureBox.ForeColor = System.Drawing.Color.Black;
            this.btnPictureBox.Location = new System.Drawing.Point(0, 268);
            this.btnPictureBox.Name = "btnPictureBox";
            this.btnPictureBox.Size = new System.Drawing.Size(233, 67);
            this.btnPictureBox.TabIndex = 21;
            this.btnPictureBox.Text = "Picture Box";
            this.btnPictureBox.Click += new System.EventHandler(this.btnPictureBox_Click_1);
            // 
            // btnConverter
            // 
            this.btnConverter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnConverter.CustomBorderColor = System.Drawing.Color.Black;
            this.btnConverter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnConverter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConverter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConverter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConverter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverter.FillColor = System.Drawing.Color.Transparent;
            this.btnConverter.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btnConverter.ForeColor = System.Drawing.Color.Black;
            this.btnConverter.Location = new System.Drawing.Point(0, 201);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(233, 67);
            this.btnConverter.TabIndex = 20;
            this.btnConverter.Text = "Currency Converter";
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click_1);
            // 
            // btnCalculator
            // 
            this.btnCalculator.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCalculator.CustomBorderColor = System.Drawing.Color.Black;
            this.btnCalculator.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnCalculator.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculator.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculator.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculator.FillColor = System.Drawing.Color.Transparent;
            this.btnCalculator.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.Location = new System.Drawing.Point(0, 134);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(233, 67);
            this.btnCalculator.TabIndex = 19;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click_1);
            // 
            // btnGroupProfile
            // 
            this.btnGroupProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGroupProfile.CustomBorderColor = System.Drawing.Color.Black;
            this.btnGroupProfile.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnGroupProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroupProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroupProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroupProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnGroupProfile.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btnGroupProfile.ForeColor = System.Drawing.Color.Black;
            this.btnGroupProfile.Location = new System.Drawing.Point(0, 67);
            this.btnGroupProfile.Name = "btnGroupProfile";
            this.btnGroupProfile.Size = new System.Drawing.Size(233, 67);
            this.btnGroupProfile.TabIndex = 18;
            this.btnGroupProfile.Text = "Group Profile";
            this.btnGroupProfile.Click += new System.EventHandler(this.btnGroupProfile_Click_2);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CustomBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(233, 67);
            this.btnDashboard.TabIndex = 17;
            this.btnDashboard.Text = "Account";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.guna2ControlBox1);
            this.TopPanel.Controls.Add(this.PicLogo);
            this.TopPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 123);
            this.TopPanel.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(952, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 25;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Finals.Properties.Resources.LOGO;
            this.PicLogo.ImageRotate = 0F;
            this.PicLogo.Location = new System.Drawing.Point(59, 33);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(153, 61);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderColor = System.Drawing.Color.Black;
            this.MainPanel.CustomBorderColor = System.Drawing.Color.Black;
            this.MainPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MainPanel.Location = new System.Drawing.Point(233, 123);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(767, 699);
            this.MainPanel.TabIndex = 7;
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.TargetControl = this.TopPanel;
            this.drag.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.ControlBox = false;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DASHBOARD";
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.DASHBOARD_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.SideNav.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel SideNav;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2PictureBox PicLogo;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnPictureBox;
        private Guna.UI2.WinForms.Guna2Button btnConverter;
        private Guna.UI2.WinForms.Guna2Button btnCalculator;
        private Guna.UI2.WinForms.Guna2Button btnGroupProfile;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.LinkLabel linkLogOut;
    }
}