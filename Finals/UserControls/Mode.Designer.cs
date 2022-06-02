namespace Finals.UserControls
{
    partial class Mode
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
            this.ModePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // ModePanel
            // 
            this.ModePanel.BackColor = System.Drawing.Color.Transparent;
            this.ModePanel.BorderRadius = 20;
            this.ModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModePanel.FillColor = System.Drawing.Color.Transparent;
            this.ModePanel.Location = new System.Drawing.Point(0, 0);
            this.ModePanel.Name = "ModePanel";
            this.ModePanel.Size = new System.Drawing.Size(1000, 700);
            this.ModePanel.TabIndex = 2;
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ModePanel);
            this.Name = "Mode";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ModePanel;
    }
}
