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

        private void DASHBOARD_Load(object sender, EventArgs e)
        {
            UserControls.DashboardHome dashboardhome = new UserControls.DashboardHome();
            MainPanel.Controls.Add(dashboardhome);
            dashboardhome.BringToFront();
        }

  
        public void btnDashboard_Click(object sender, EventArgs e)
        {
            UserControls.DashboardHome dashboardhome = new UserControls.DashboardHome();
            MainPanel.Controls.Add(dashboardhome);
            dashboardhome.BringToFront();
        }

        public void btnGroupProfile_Click_2(object sender, EventArgs e)
        {
            UserControls.GroupProfileUC GroupProfileForm = new UserControls.GroupProfileUC();
            MainPanel.Controls.Add(GroupProfileForm);
            GroupProfileForm.BringToFront();
        }

        public void btnCalculator_Click_1(object sender, EventArgs e)
        {
            UserControls.CalculatorUC CalculatorForm = new UserControls.CalculatorUC();
            MainPanel.Controls.Add(CalculatorForm);
            CalculatorForm.BringToFront();
        }

        public void btnConverter_Click_1(object sender, EventArgs e)
        {
            UserControls.ConverterUC ConverterForm = new UserControls.ConverterUC();
            MainPanel.Controls.Add(ConverterForm);
            ConverterForm.BringToFront();
        }

        public void btnPictureBox_Click_1(object sender, EventArgs e)
        {
            UserControls.PictureBoxUC PictureBoxForm = new UserControls.PictureBoxUC();
            MainPanel.Controls.Add(PictureBoxForm);
            PictureBoxForm.BringToFront();
        }
    }
}
