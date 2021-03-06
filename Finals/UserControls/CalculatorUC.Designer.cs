namespace Finals.UserControls
{
    partial class CalculatorUC
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
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
            this.btnDisplayForm.Location = new System.Drawing.Point(396, 328);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(263, 62);
            this.btnDisplayForm.TabIndex = 5;
            this.btnDisplayForm.Text = "Display Form";
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simple Calculating Application";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.CustomizableEdges.BottomRight = false;
            this.guna2PictureBox2.CustomizableEdges.TopRight = false;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::Finals.Properties.Resources.calc;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(39, 139);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(314, 456);
            this.guna2PictureBox2.TabIndex = 27;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 176);
            this.label2.TabIndex = 28;
            this.label2.Text = "Simple Calculating Application\r\n\r\nDescription : It is an application that accepts" +
    " 2 numeric entries and performs basic arithmetic operations ( Addition, Subtract" +
    "ion, Multiplication and Division) ";
            // 
            // CalculatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorUC";
            this.Size = new System.Drawing.Size(751, 700);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDisplayForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
