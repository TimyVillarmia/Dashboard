using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();

        }


        public void DASHBOARD_Load(object sender, EventArgs e)
        {

            btnDashboard.FillColor = Color.FromArgb(255, 110, 108);
            btnDashboard.ForeColor = Color.White;

            UserControls.DashboardHome dashhome = new UserControls.DashboardHome();
            MainPanel.Controls.Add(dashhome);

        }


        public void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.FromArgb(255, 110, 108);
            btnDashboard.ForeColor = Color.White;
            btnGroupProfile.FillColor = Color.Transparent;
            btnGroupProfile.ForeColor = Color.FromArgb(32, 22, 16);
            btnCalculator.FillColor = Color.Transparent;
            btnCalculator.ForeColor = Color.FromArgb(32, 22, 16);
            btnConverter.FillColor = Color.Transparent;
            btnConverter.ForeColor = Color.FromArgb(32, 22, 16);
            btnPictureBox.FillColor = Color.Transparent;
            btnPictureBox.ForeColor = Color.FromArgb(32, 22, 16);


            UserControls.DashboardHome dashhome = new UserControls.DashboardHome();

            if (!MainPanel.Controls.Contains(dashhome))
            {

                MainPanel.Controls.Add(dashhome);
                dashhome.BringToFront();


            }
            else
            { 
                dashhome.BringToFront();

            }





        }

        public void btnGroupProfile_Click_2(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.ForeColor = Color.FromArgb(32, 22, 16);
            btnGroupProfile.FillColor = Color.FromArgb(255, 110, 108);
            btnGroupProfile.ForeColor = Color.White;
            btnCalculator.FillColor = Color.Transparent;
            btnCalculator.ForeColor = Color.FromArgb(32, 22, 16);
            btnConverter.FillColor = Color.Transparent;
            btnConverter.ForeColor = Color.FromArgb(32, 22, 16);
            btnPictureBox.FillColor = Color.Transparent;
            btnPictureBox.ForeColor = Color.FromArgb(32, 22, 16);


            UserControls.GroupProfileUC GroupProfileForm = new UserControls.GroupProfileUC();
            MainPanel.Controls.Add(GroupProfileForm);
            GroupProfileForm.BringToFront();
        }

        public void btnCalculator_Click_1(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.ForeColor = Color.FromArgb(32, 22, 16);
            btnGroupProfile.FillColor = Color.Transparent;
            btnGroupProfile.ForeColor = Color.FromArgb(32, 22, 16);
            btnCalculator.FillColor = Color.FromArgb(255, 110, 108);
            btnCalculator.ForeColor = Color.White;
            btnConverter.FillColor = Color.Transparent;
            btnConverter.ForeColor = Color.FromArgb(32, 22, 16);
            btnPictureBox.FillColor = Color.Transparent;
            btnPictureBox.ForeColor = Color.FromArgb(32, 22, 16);


            UserControls.CalculatorUC CalculatorForm = new UserControls.CalculatorUC();
            MainPanel.Controls.Add(CalculatorForm);
            CalculatorForm.BringToFront();
        }

        public void btnConverter_Click_1(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.ForeColor = Color.FromArgb(32, 22, 16);
            btnGroupProfile.FillColor = Color.Transparent;
            btnGroupProfile.ForeColor = Color.FromArgb(32, 22, 16);
            btnCalculator.FillColor = Color.Transparent;
            btnCalculator.ForeColor = Color.FromArgb(32, 22, 16);
            btnConverter.FillColor = Color.FromArgb(255, 110, 108);
            btnConverter.ForeColor = Color.White;
            btnPictureBox.FillColor = Color.Transparent;
            btnPictureBox.ForeColor = Color.FromArgb(32, 22, 16);

            UserControls.ConverterUC ConverterForm = new UserControls.ConverterUC();
            MainPanel.Controls.Add(ConverterForm);
            ConverterForm.BringToFront();
        }

        public void btnPictureBox_Click_1(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.ForeColor = Color.FromArgb(32, 22, 16);
            btnGroupProfile.FillColor = Color.Transparent;
            btnGroupProfile.ForeColor = Color.FromArgb(32, 22, 16);
            btnCalculator.FillColor = Color.Transparent;
            btnCalculator.ForeColor = Color.FromArgb(32, 22, 16);
            btnConverter.FillColor = Color.Transparent;
            btnConverter.ForeColor = Color.FromArgb(32, 22, 16);
            btnPictureBox.FillColor = Color.FromArgb(255, 110, 108);
            btnPictureBox.ForeColor = Color.White;

            UserControls.PictureBoxUC PictureBoxForm = new UserControls.PictureBoxUC();
            MainPanel.Controls.Add(PictureBoxForm);
            PictureBoxForm.BringToFront();
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
