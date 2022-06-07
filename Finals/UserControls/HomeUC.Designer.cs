namespace Finals.UserControls
{
    partial class HomeUC
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
            this.btnGetStarted = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeadline2 = new System.Windows.Forms.Label();
            this.picHeadline1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picMainimage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.HomePanel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadline1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainimage)).BeginInit();
            this.HomePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.Transparent;
            this.btnGetStarted.BorderRadius = 20;
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetStarted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetStarted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetStarted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetStarted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnGetStarted.Font = new System.Drawing.Font("Roboto Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(59, 517);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(352, 86);
            this.btnGetStarted.TabIndex = 47;
            this.btnGetStarted.Text = "GET STARTED";
            this.btnGetStarted.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // lblHeadline2
            // 
            this.lblHeadline2.AutoSize = true;
            this.lblHeadline2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadline2.Font = new System.Drawing.Font("Roboto Light", 18F);
            this.lblHeadline2.ForeColor = System.Drawing.Color.Black;
            this.lblHeadline2.Location = new System.Drawing.Point(54, 439);
            this.lblHeadline2.Name = "lblHeadline2";
            this.lblHeadline2.Size = new System.Drawing.Size(504, 58);
            this.lblHeadline2.TabIndex = 46;
            this.lblHeadline2.Text = "CS201 Dashboard is a powerful and flexible \ndesktop application created by CS201 " +
    "Group 2  ";
            // 
            // picHeadline1
            // 
            this.picHeadline1.BackColor = System.Drawing.Color.Transparent;
            this.picHeadline1.Image = global::Finals.Properties.Resources.headline;
            this.picHeadline1.ImageRotate = 0F;
            this.picHeadline1.Location = new System.Drawing.Point(59, 89);
            this.picHeadline1.Name = "picHeadline1";
            this.picHeadline1.Size = new System.Drawing.Size(489, 328);
            this.picHeadline1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeadline1.TabIndex = 45;
            this.picHeadline1.TabStop = false;
            // 
            // picMainimage
            // 
            this.picMainimage.BackColor = System.Drawing.Color.Transparent;
            this.picMainimage.FillColor = System.Drawing.Color.Transparent;
            this.picMainimage.Image = global::Finals.Properties.Resources.casual_life_3d_girl_and_boy_sitting_with_laptop_1;
            this.picMainimage.ImageRotate = 0F;
            this.picMainimage.Location = new System.Drawing.Point(627, 40);
            this.picMainimage.Name = "picMainimage";
            this.picMainimage.Size = new System.Drawing.Size(453, 524);
            this.picMainimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainimage.TabIndex = 44;
            this.picMainimage.TabStop = false;
            // 
            // HomePanel1
            // 
            this.HomePanel1.Controls.Add(this.picMainimage);
            this.HomePanel1.Controls.Add(this.picHeadline1);
            this.HomePanel1.Controls.Add(this.lblHeadline2);
            this.HomePanel1.Controls.Add(this.btnGetStarted);
            this.HomePanel1.Location = new System.Drawing.Point(0, 0);
            this.HomePanel1.Name = "HomePanel1";
            this.HomePanel1.Size = new System.Drawing.Size(1000, 700);
            this.HomePanel1.TabIndex = 46;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HomePanel1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadline1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainimage)).EndInit();
            this.HomePanel1.ResumeLayout(false);
            this.HomePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGetStarted;
        private System.Windows.Forms.Label lblHeadline2;
        private Guna.UI2.WinForms.Guna2PictureBox picHeadline1;
        private Guna.UI2.WinForms.Guna2PictureBox picMainimage;
        private Guna.UI2.WinForms.Guna2Panel HomePanel1;
    }
}
