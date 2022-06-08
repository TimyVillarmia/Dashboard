using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity34_Group2_CS201
{
    public partial class GroupProfile : Form
    {
        private static GroupProfile _instance;
        public static GroupProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GroupProfile();
                return _instance;
            }
        }

        public GroupProfile()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var group_profile = ("Group Number: " + GroupNum_combox.Text + " Section: " + Section_combox.Text + "\nLeader: " + Leader_txtbox.Text + "\nMembers:\n" + Member1_txtbox.Text + "\n" + Member2_txtbox.Text + "\n" + Member3_txtbox.Text + "\n" + Member4_txtbox.Text);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit? ", " ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(group_profile);
                this.Close();
            }
            else
            {
                //do nothing
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GroupNum_combox.Text = "";
            Section_combox.Text = "";
            Leader_txtbox.Text = "";
            Member1_txtbox.Text = "";
            Member2_txtbox.Text = "";
            Member3_txtbox.Text = "";
            Member4_txtbox.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
