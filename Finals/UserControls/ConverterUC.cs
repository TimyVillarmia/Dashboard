using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.UserControls
{
    public partial class ConverterUC : UserControl
    {
        public ConverterUC()
        {
            InitializeComponent();
        }

        private void btnDisplayForm_Click(object sender, EventArgs e)
        {
            var showConverter = new Activity78_Group2_CS201.CurrencyConverter();
            showConverter.Show();
        }
    }
}
