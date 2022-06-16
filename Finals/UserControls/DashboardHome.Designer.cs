namespace Finals.UserControls
{
    partial class DashboardHome
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.lblName.Location = new System.Drawing.Point(210, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(328, 77);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Username";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.lblHello.Location = new System.Drawing.Point(27, 41);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(218, 77);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Hello, ";
            // 
            // DashboardHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHello);
            this.Name = "DashboardHome";
            this.Size = new System.Drawing.Size(751, 700);
            this.Load += new System.EventHandler(this.DashboardHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHello;
    }
}
