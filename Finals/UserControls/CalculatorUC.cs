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
    public partial class CalculatorUC : UserControl
    {
        private static CalculatorUC _instance;
        public static CalculatorUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CalculatorUC();
                return _instance;
            }
        }
        public CalculatorUC()
        {
            InitializeComponent();
        }
    }
}
