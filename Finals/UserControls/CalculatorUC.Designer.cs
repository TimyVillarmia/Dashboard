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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CalcPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtInput2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInput1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInterpreter = new System.Windows.Forms.Label();
            this.btnEqual = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnMultiply = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDivide = new Guna.UI2.WinForms.Guna2Button();
            this.btnPercent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.CalcPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.BorderRadius = 20;
            this.btnDisplayForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplayForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplayForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnDisplayForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisplayForm.ForeColor = System.Drawing.Color.White;
            this.btnDisplayForm.Location = new System.Drawing.Point(409, 175);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(193, 55);
            this.btnDisplayForm.TabIndex = 5;
            this.btnDisplayForm.Text = "Display Form";
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(399, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculator";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.CalcPanel);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(400, 588);
            this.guna2Panel1.TabIndex = 6;
            // 
            // CalcPanel
            // 
            this.CalcPanel.Controls.Add(this.txtInput2);
            this.CalcPanel.Controls.Add(this.txtInput1);
            this.CalcPanel.Controls.Add(this.lblResult);
            this.CalcPanel.Controls.Add(this.lblInterpreter);
            this.CalcPanel.Controls.Add(this.btnEqual);
            this.CalcPanel.Controls.Add(this.btnAdd);
            this.CalcPanel.Controls.Add(this.btnMinus);
            this.CalcPanel.Controls.Add(this.btnCancel);
            this.CalcPanel.Controls.Add(this.btnMultiply);
            this.CalcPanel.Controls.Add(this.btnClear);
            this.CalcPanel.Controls.Add(this.btnDivide);
            this.CalcPanel.Controls.Add(this.btnPercent);
            this.CalcPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.CalcPanel.Location = new System.Drawing.Point(36, 76);
            this.CalcPanel.Name = "CalcPanel";
            this.CalcPanel.ShadowDecoration.Depth = 50;
            this.CalcPanel.Size = new System.Drawing.Size(295, 436);
            this.CalcPanel.TabIndex = 2;
            // 
            // txtInput2
            // 
            this.txtInput2.BorderColor = System.Drawing.Color.Black;
            this.txtInput2.BorderThickness = 0;
            this.txtInput2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput2.DefaultText = "";
            this.txtInput2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput2.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtInput2.ForeColor = System.Drawing.Color.Black;
            this.txtInput2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput2.Location = new System.Drawing.Point(14, 66);
            this.txtInput2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.PasswordChar = '\0';
            this.txtInput2.PlaceholderText = "";
            this.txtInput2.SelectedText = "";
            this.txtInput2.Size = new System.Drawing.Size(266, 39);
            this.txtInput2.TabIndex = 23;
            this.txtInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInput1
            // 
            this.txtInput1.BorderColor = System.Drawing.Color.Black;
            this.txtInput1.BorderThickness = 0;
            this.txtInput1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput1.DefaultText = "";
            this.txtInput1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtInput1.ForeColor = System.Drawing.Color.Black;
            this.txtInput1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput1.Location = new System.Drawing.Point(14, 18);
            this.txtInput1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.PasswordChar = '\0';
            this.txtInput1.PlaceholderText = "";
            this.txtInput1.SelectedText = "";
            this.txtInput1.Size = new System.Drawing.Size(266, 39);
            this.txtInput1.TabIndex = 22;
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(210, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 60);
            this.lblResult.TabIndex = 21;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInterpreter
            // 
            this.lblInterpreter.BackColor = System.Drawing.Color.Transparent;
            this.lblInterpreter.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInterpreter.ForeColor = System.Drawing.Color.DimGray;
            this.lblInterpreter.Location = new System.Drawing.Point(157, 112);
            this.lblInterpreter.Name = "lblInterpreter";
            this.lblInterpreter.Size = new System.Drawing.Size(123, 20);
            this.lblInterpreter.TabIndex = 20;
            this.lblInterpreter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Transparent;
            this.btnEqual.BorderRadius = 10;
            this.btnEqual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEqual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnEqual.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnEqual.Location = new System.Drawing.Point(116, 358);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.ShadowDecoration.BorderRadius = 10;
            this.btnEqual.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnEqual.ShadowDecoration.Depth = 50;
            this.btnEqual.ShadowDecoration.Enabled = true;
            this.btnEqual.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnEqual.Size = new System.Drawing.Size(164, 60);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnAdd.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnAdd.Location = new System.Drawing.Point(210, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.BorderRadius = 10;
            this.btnAdd.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnAdd.ShadowDecoration.Depth = 50;
            this.btnAdd.ShadowDecoration.Enabled = true;
            this.btnAdd.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnAdd.Size = new System.Drawing.Size(70, 60);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderRadius = 10;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnMinus.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnMinus.Location = new System.Drawing.Point(116, 280);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.BorderRadius = 10;
            this.btnMinus.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnMinus.ShadowDecoration.Depth = 50;
            this.btnMinus.ShadowDecoration.Enabled = true;
            this.btnMinus.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnMinus.Size = new System.Drawing.Size(70, 60);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnCancel.Font = new System.Drawing.Font("Roboto Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnCancel.Location = new System.Drawing.Point(20, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.BorderRadius = 10;
            this.btnCancel.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnCancel.ShadowDecoration.Depth = 50;
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnCancel.Size = new System.Drawing.Size(70, 60);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiply.BorderRadius = 10;
            this.btnMultiply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnMultiply.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnMultiply.Location = new System.Drawing.Point(20, 280);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.ShadowDecoration.BorderRadius = 10;
            this.btnMultiply.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnMultiply.ShadowDecoration.Depth = 50;
            this.btnMultiply.ShadowDecoration.Enabled = true;
            this.btnMultiply.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnMultiply.Size = new System.Drawing.Size(70, 60);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "x";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnClear.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnClear.Location = new System.Drawing.Point(210, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.BorderRadius = 10;
            this.btnClear.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnClear.ShadowDecoration.Depth = 50;
            this.btnClear.ShadowDecoration.Enabled = true;
            this.btnClear.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnClear.Size = new System.Drawing.Size(70, 60);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "AC";
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Transparent;
            this.btnDivide.BorderRadius = 10;
            this.btnDivide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnDivide.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnDivide.Location = new System.Drawing.Point(116, 206);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.ShadowDecoration.BorderRadius = 10;
            this.btnDivide.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnDivide.ShadowDecoration.Depth = 50;
            this.btnDivide.ShadowDecoration.Enabled = true;
            this.btnDivide.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnDivide.Size = new System.Drawing.Size(70, 60);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "÷";
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Transparent;
            this.btnPercent.BorderRadius = 10;
            this.btnPercent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPercent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.btnPercent.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(151)))), ((int)(((byte)(232)))));
            this.btnPercent.Location = new System.Drawing.Point(20, 206);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.ShadowDecoration.BorderRadius = 10;
            this.btnPercent.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btnPercent.ShadowDecoration.Depth = 50;
            this.btnPercent.ShadowDecoration.Enabled = true;
            this.btnPercent.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.btnPercent.Size = new System.Drawing.Size(70, 60);
            this.btnPercent.TabIndex = 12;
            this.btnPercent.Text = "%";
            // 
            // CalculatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorUC";
            this.Size = new System.Drawing.Size(751, 700);
            this.guna2Panel1.ResumeLayout(false);
            this.CalcPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDisplayForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel CalcPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtInput2;
        private Guna.UI2.WinForms.Guna2TextBox txtInput1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInterpreter;
        private Guna.UI2.WinForms.Guna2Button btnEqual;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnMultiply;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDivide;
        private Guna.UI2.WinForms.Guna2Button btnPercent;
    }
}
