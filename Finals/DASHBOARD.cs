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

        private void btnGroupProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGroupProfile_Click_1(object sender, EventArgs e)
        {
            UserControls.GroupProfileUC GroupProfileForm = new UserControls.GroupProfileUC();
            MainPanel.Controls.Add(GroupProfileForm);
            GroupProfileForm.BringToFront();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            UserControls.CalculatorUC CalculatorForm = new UserControls.CalculatorUC();
            MainPanel.Controls.Add(CalculatorForm);
            CalculatorForm.BringToFront();
        }
    }
}
