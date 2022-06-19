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
    public partial class DashboardHome : UserControl
    {
        public DashboardHome()
        {
            InitializeComponent();
        }

        private void DashboardHome_Load(object sender, EventArgs e)
        {

            txtCourse.Visible = false;
            txtSection.Visible = false;
            txtAge.Visible = false;
            ComboGender.Visible = false;
            dateBirthdate.Visible = false;
            txtPhone.Visible = false;
            txtBio.Visible = false;

            if (ModeUC.ADMIN == true)
            {
                lblName.Text = "Admin";
                lblUsername.Text = "Admin";
                btnEdit.Visible = false;
                btnSave.Visible = false;
            }
            else
            {
                lblName.Text = ModeUC.RegisteredUsername;
                lblEmail.Text = ModeUC.RegisteredEmail;
                lblUsername.Text = ModeUC.RegisteredUsername;

                btnEdit.Visible = true;

                lblCourse.Text = string.Empty;
                lblSection.Text = string.Empty;
                lblAge.Text = string.Empty;
                lblGender.Text = string.Empty;
                lblBirthday.Text = string.Empty;
                lblPhone.Text = string.Empty;

            }
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                ProfilePicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void ProfilePicture_MouseHover(object sender, EventArgs e)
        {
            ProfilePicture.FillColor = Color.Gray;
        }

        private void guna2CircleButton2_MouseHover(object sender, EventArgs e)
        {
            ProfilePicture.FillColor = Color.Gray;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                ProfilePicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSave.Visible = true;

            txtCourse.Visible = true;
            txtSection.Visible = true;
            txtAge.Visible = true;
            ComboGender.Visible = true;
            dateBirthdate.Visible = true;
            txtPhone.Visible = true;
            txtBio.Visible = true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnSave.Visible = false;

            txtCourse.Visible = false;
            txtSection.Visible = false;
            txtAge.Visible = false;
            ComboGender.Visible = false;
            dateBirthdate.Visible = false;
            txtPhone.Visible = false;
            txtBio.Visible = false;

            lblCourse.Text = txtCourse.Text;
            lblSection.Text = txtSection.Text;
            lblAge.Text = txtAge.Text;
            lblGender.Text = ComboGender.Text;
            lblBirthday.Text = dateBirthdate.Text;
            lblPhone.Text = txtPhone.Text;
            lblBio.TextAlign = ContentAlignment.TopLeft;
            lblBio.Text = txtBio.Text;



        }
    }
}
