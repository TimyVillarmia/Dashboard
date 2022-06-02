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
            this.BtnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeadline2 = new System.Windows.Forms.Label();
            this.BtnSIgnIn = new Guna.UI2.WinForms.Guna2TileButton();
            this.picHeadline1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picMainimage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.HomePanel = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadline1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainimage)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.BorderRadius = 20;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.BtnSignUp.Font = new System.Drawing.Font("Roboto Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.Location = new System.Drawing.Point(321, 543);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(240, 76);
            this.BtnSignUp.TabIndex = 47;
            this.BtnSignUp.Text = "SIGN UP";
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
            // BtnSIgnIn
            // 
            this.BtnSIgnIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnSIgnIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.BtnSIgnIn.BorderRadius = 20;
            this.BtnSIgnIn.BorderThickness = 2;
            this.BtnSIgnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSIgnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSIgnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSIgnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSIgnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSIgnIn.FillColor = System.Drawing.Color.Transparent;
            this.BtnSIgnIn.Font = new System.Drawing.Font("Roboto Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSIgnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.BtnSIgnIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.BtnSIgnIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSIgnIn.Location = new System.Drawing.Point(59, 543);
            this.BtnSIgnIn.Name = "BtnSIgnIn";
            this.BtnSIgnIn.Size = new System.Drawing.Size(240, 76);
            this.BtnSIgnIn.TabIndex = 48;
            this.BtnSIgnIn.Text = "SIGN IN";
            this.BtnSIgnIn.Click += new System.EventHandler(this.BtnSIgnIn_Click_1);
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
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.picMainimage);
            this.HomePanel.Controls.Add(this.picHeadline1);
            this.HomePanel.Controls.Add(this.BtnSIgnIn);
            this.HomePanel.Controls.Add(this.lblHeadline2);
            this.HomePanel.Controls.Add(this.BtnSignUp);
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1000, 700);
            this.HomePanel.TabIndex = 46;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HomePanel);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadline1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainimage)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnSignUp;
        private System.Windows.Forms.Label lblHeadline2;
        private Guna.UI2.WinForms.Guna2TileButton BtnSIgnIn;
        private Guna.UI2.WinForms.Guna2PictureBox picHeadline1;
        private Guna.UI2.WinForms.Guna2PictureBox picMainimage;
        private Guna.UI2.WinForms.Guna2Panel HomePanel;
    }
}
