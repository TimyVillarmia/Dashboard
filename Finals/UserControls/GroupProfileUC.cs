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
    public partial class GroupProfileUC : UserControl
    {

        private static GroupProfileUC _instance;
        public static GroupProfileUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GroupProfileUC();
                return _instance;
            }
        }
        public GroupProfileUC()
        {
            InitializeComponent();
        }

        private void GroupProfileUC_Load(object sender, EventArgs e)
        {
       
        }

        private void btnDisplayForm_Click(object sender, EventArgs e)
        {
            var showGroupProfile = new Activity34_Group2_CS201.GroupProfile();
            showGroupProfile.Show();
        }
    }
}
