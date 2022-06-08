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
    public partial class MainForm : Form
    {
        


        public MainForm()
        {
            InitializeComponent();

            HomePanel.Controls.Add(UserControls.HomeUC.Instance);
            UserControls.HomeUC.Instance.BringToFront();

        }
    


        private void BtnHome_Click(object sender, EventArgs e)
        {
            BtnHome.FillColor = Color.FromArgb(255, 110, 108);
            BtnHome.ForeColor = Color.White;
            BtnTeam.FillColor = Color.Transparent;
            BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            BtnProjects.FillColor = Color.Transparent;
            BtnProjects.ForeColor = Color.FromArgb(32, 22, 16);

            UserControls.ModeUC.Instance.SendToBack();

            if (!HomePanel.Controls.Contains(UserControls.HomeUC.Instance))
            {

                HomePanel.Controls.Add(UserControls.HomeUC.Instance);
                UserControls.HomeUC.Instance.Dock = DockStyle.Fill;
                UserControls.HomeUC.Instance.BringToFront();
            }
            else
            {
                UserControls.HomeUC.Instance.BringToFront();

            }


        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            BtnHome.FillColor = Color.Transparent;
            BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            BtnTeam.FillColor = Color.FromArgb(255, 110, 108);
            BtnTeam.ForeColor = Color.White;
            BtnProjects.FillColor = Color.Transparent;
            BtnProjects.ForeColor = Color.FromArgb(32, 22, 16);

            if (!HomePanel.Controls.Contains(UserControls.TeamUC.Instance))
            {
                HomePanel.Controls.Add(UserControls.TeamUC.Instance);
                UserControls.TeamUC.Instance.Dock = DockStyle.Fill;

                UserControls.TeamUC.Instance.BringToFront();
            }
            else
            {
                UserControls.TeamUC.Instance.BringToFront();

            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            BtnHome.FillColor = Color.Transparent;
            BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            BtnTeam.FillColor = Color.Transparent;
            BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            BtnProjects.FillColor = Color.FromArgb(255, 110, 108);
            BtnProjects.ForeColor = Color.White;


            if (!HomePanel.Controls.Contains(UserControls.ProjectsUC.Instance))
            {
                HomePanel.Controls.Add(UserControls.ProjectsUC.Instance);
                UserControls.HomeUC.Instance.Dock = DockStyle.Fill;
                UserControls.ProjectsUC.Instance.BringToFront();
            }
            else
            {
                UserControls.ProjectsUC.Instance.BringToFront();
            }

        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            UserControls.HomeUC.Instance.BringToFront();


        }

        private void BtnSIgnIn_Click(object sender, EventArgs e)
        {
        }
    }
}

