namespace Finals.UserControls
{
    partial class ConverterUC
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
            this.btnDisplayForm = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.BorderRadius = 12;
            this.btnDisplayForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplayForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplayForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnDisplayForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisplayForm.ForeColor = System.Drawing.Color.White;
            this.btnDisplayForm.Location = new System.Drawing.Point(504, 461);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(214, 62);
            this.btnDisplayForm.TabIndex = 7;
            this.btnDisplayForm.Text = "Display Form";
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 124);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conversion Application ( Currency Converter ) ";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.CustomizableEdges.BottomRight = false;
            this.guna2PictureBox3.CustomizableEdges.TopRight = false;
            this.guna2PictureBox3.Image = global::Finals.Properties.Resources.convert;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(10, 139);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(477, 367);
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 287);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conversion Application ( Currency Converter ) \r\n\r\nDescription :  It is an applica" +
    "tion that converts currency. \r\n\r\nConversion Process\r\n\r\nUSD <--> JPY\r\nPHP <--> US" +
    "D\r\nPHP <--> JPY ";
            // 
            // ConverterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.label1);
            this.Name = "ConverterUC";
            this.Size = new System.Drawing.Size(751, 700);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDisplayForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label2;
    }
}
