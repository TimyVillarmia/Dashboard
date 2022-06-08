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
            if (!MainPanel.Controls.Contains(UserControls.GroupProfileUC.Instance))
            {
                MainPanel.Controls.Add(UserControls.GroupProfileUC.Instance);
                UserControls.GroupProfileUC.Instance.Dock = DockStyle.Fill;
                UserControls.GroupProfileUC.Instance.BringToFront();
            }
            else
            {
                UserControls.GroupProfileUC.Instance.BringToFront();
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UserControls.CalculatorUC.Instance))
            {
                MainPanel.Controls.Add(UserControls.CalculatorUC.Instance);
                UserControls.CalculatorUC.Instance.Dock = DockStyle.Fill;
                UserControls.CalculatorUC.Instance.BringToFront();
            }
            else
            {
                UserControls.CalculatorUC.Instance.BringToFront();
            }
        }
    }
}
