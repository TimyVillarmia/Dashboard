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
    public partial class ProductUC : UserControl
    {
        private static ProductUC _instance;
        public static ProductUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductUC();
                return _instance;
            }
        }
        public ProductUC()
        {
            InitializeComponent();
        }
    }
}
