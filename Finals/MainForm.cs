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

           

        }



        private void BtnHome_Click(object sender, EventArgs e)
        {

            BtnHome.FillColor = Color.FromArgb(255, 110, 108);
            BtnHome.ForeColor = Color.White;
            BtnTeam.FillColor = Color.Transparent;
            BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            BtnProjects.FillColor = Color.Transparent;
            BtnProjects.ForeColor = Color.FromArgb(32, 22, 16);
            
            UserControls.HomeUC HomePage = new UserControls.HomeUC();
            HomePanel.Controls.Add(HomePage);
            HomePage.BringToFront();

        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            BtnHome.FillColor = Color.Transparent;
            BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            BtnTeam.FillColor = Color.FromArgb(255, 110, 108);
            BtnTeam.ForeColor = Color.White;
            BtnProjects.FillColor = Color.Transparent;
            BtnProjects.ForeColor = Color.FromArgb(32, 22, 16);

            UserControls.TeamUC TeamPage = new UserControls.TeamUC();
            HomePanel.Controls.Add(TeamPage);
            TeamPage.BringToFront();

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            BtnHome.FillColor = Color.Transparent;
            BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            BtnTeam.FillColor = Color.Transparent;
            BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            BtnProjects.FillColor = Color.FromArgb(255, 110, 108);
            BtnProjects.ForeColor = Color.White;

            UserControls.ProjectsUC ProjectsPage = new UserControls.ProjectsUC();
            HomePanel.Controls.Add(ProjectsPage);
            ProjectsPage.BringToFront();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserControls.HomeUC home = new UserControls.HomeUC();
            HomePanel.Controls.Add(home);
            home.BringToFront();

        }




    }
}

