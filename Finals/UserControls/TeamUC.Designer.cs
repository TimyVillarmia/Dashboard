namespace Finals.UserControls
{
    partial class TeamUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamUC));
            this.panelIntroduction = new Guna.UI2.WinForms.Guna2Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.panelMemberDesc = new Guna.UI2.WinForms.Guna2Panel();
            this.picFBLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkFacebook = new System.Windows.Forms.LinkLabel();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelIntroduction.SuspendLayout();
            this.panelMemberDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIntroduction
            // 
            this.panelIntroduction.Controls.Add(this.lblName);
            this.panelIntroduction.Controls.Add(this.lblText);
            this.panelIntroduction.Controls.Add(this.panelMemberDesc);
            this.panelIntroduction.FillColor = System.Drawing.Color.White;
            this.panelIntroduction.Location = new System.Drawing.Point(250, 442);
            this.panelIntroduction.Name = "panelIntroduction";
            this.panelIntroduction.Size = new System.Drawing.Size(750, 258);
            this.panelIntroduction.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.lblName.Location = new System.Drawing.Point(28, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(230, 58);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Our Story";
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.White;
            this.lblText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(32, 73);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(701, 181);
            this.lblText.TabIndex = 9;
            this.lblText.Text = resources.GetString("lblText.Text");
            // 
            // panelMemberDesc
            // 
            this.panelMemberDesc.Controls.Add(this.picFBLogo);
            this.panelMemberDesc.Controls.Add(this.linkFacebook);
            this.panelMemberDesc.Location = new System.Drawing.Point(32, 76);
            this.panelMemberDesc.Name = "panelMemberDesc";
            this.panelMemberDesc.Size = new System.Drawing.Size(701, 181);
            this.panelMemberDesc.TabIndex = 12;
            // 
            // picFBLogo
            // 
            this.picFBLogo.Image = global::Finals.Properties.Resources.icons8_facebook_48;
            this.picFBLogo.ImageRotate = 0F;
            this.picFBLogo.Location = new System.Drawing.Point(4, 5);
            this.picFBLogo.Name = "picFBLogo";
            this.picFBLogo.Size = new System.Drawing.Size(48, 48);
            this.picFBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFBLogo.TabIndex = 21;
            this.picFBLogo.TabStop = false;
            // 
            // linkFacebook
            // 
            this.linkFacebook.AutoSize = true;
            this.linkFacebook.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFacebook.Location = new System.Drawing.Point(50, 11);
            this.linkFacebook.Name = "linkFacebook";
            this.linkFacebook.Size = new System.Drawing.Size(554, 35);
            this.linkFacebook.TabIndex = 20;
            this.linkFacebook.TabStop = true;
            this.linkFacebook.Text = "https://www.facebook.com/VillarmiaTimy";
            this.linkFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFacebook_LinkClicked);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.lblHeadline.Location = new System.Drawing.Point(255, 40);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(525, 77);
            this.lblHeadline.TabIndex = 18;
            this.lblHeadline.Text = "MEET THE TEAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.label2.Location = new System.Drawing.Point(456, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "CS201 - GROUP 2";
            // 
            // picbox5
            // 
            this.picbox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox5.Image = global::Finals.Properties.Resources.casual_life_3d_young_man_using_laptop_and_talking_on_the_phone;
            this.picbox5.ImageRotate = 0F;
            this.picbox5.Location = new System.Drawing.Point(0, 442);
            this.picbox5.Name = "picbox5";
            this.picbox5.Size = new System.Drawing.Size(250, 258);
            this.picbox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox5.TabIndex = 17;
            this.picbox5.TabStop = false;
            this.picbox5.Click += new System.EventHandler(this.picbox5_Click);
            // 
            // picbox1
            // 
            this.picbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox1.Image = global::Finals.Properties.Resources.AnzelPhoto;
            this.picbox1.ImageRotate = 0F;
            this.picbox1.Location = new System.Drawing.Point(0, 184);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(250, 258);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 16;
            this.picbox1.TabStop = false;
            this.picbox1.Click += new System.EventHandler(this.picbox1_Click);
            this.picbox1.MouseHover += new System.EventHandler(this.picbox1_MouseHover);
            // 
            // picbox2
            // 
            this.picbox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox2.FillColor = System.Drawing.Color.Black;
            this.picbox2.Image = global::Finals.Properties.Resources.download1;
            this.picbox2.ImageRotate = 0F;
            this.picbox2.Location = new System.Drawing.Point(250, 184);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(250, 258);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 15;
            this.picbox2.TabStop = false;
            this.picbox2.Click += new System.EventHandler(this.picbox2_Click);
            // 
            // picbox3
            // 
            this.picbox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox3.Image = global::Finals.Properties.Resources.business_3d_young_man_in_casual_clothes_sitting_on_the_floor_with_phone;
            this.picbox3.ImageRotate = 0F;
            this.picbox3.Location = new System.Drawing.Point(500, 184);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(250, 258);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox3.TabIndex = 14;
            this.picbox3.TabStop = false;
            this.picbox3.Click += new System.EventHandler(this.picbox3_Click);
            // 
            // picbox4
            // 
            this.picbox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox4.Image = global::Finals.Properties.Resources.business_3d_young_woman_high_five_with_dog_in_sweater;
            this.picbox4.ImageRotate = 0F;
            this.picbox4.Location = new System.Drawing.Point(750, 184);
            this.picbox4.Name = "picbox4";
            this.picbox4.Size = new System.Drawing.Size(250, 258);
            this.picbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox4.TabIndex = 13;
            this.picbox4.TabStop = false;
            this.picbox4.Click += new System.EventHandler(this.picbox4_Click);
            // 
            // TeamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.picbox5);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picbox4);
            this.Controls.Add(this.panelIntroduction);
            this.Name = "TeamUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.panelIntroduction.ResumeLayout(false);
            this.panelIntroduction.PerformLayout();
            this.panelMemberDesc.ResumeLayout(false);
            this.panelMemberDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelIntroduction;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox picbox4;
        private Guna.UI2.WinForms.Guna2PictureBox picbox3;
        private Guna.UI2.WinForms.Guna2PictureBox picbox2;
        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2PictureBox picbox5;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelMemberDesc;
        private Guna.UI2.WinForms.Guna2PictureBox picFBLogo;
        private System.Windows.Forms.LinkLabel linkFacebook;
    }
}
