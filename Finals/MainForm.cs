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

            this.BtnHome.FillColor = Color.FromArgb(255, 110, 108);
            this.BtnHome.ForeColor = Color.White;


            MainPanel.Controls.Add(UserControls.HomeUC.Instance);
            UserControls.HomeUC.Instance.BringToFront();

            //Controls.Add(UserControls.HomeUC.Instance);
            //UserControls.HomeUC.Instance.Location = new Point(0, 100);
            //UserControls.HomeUC.Instance.BringToFront();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //UserControls.HomeUC.Instance.BackColor = Color.Transparent;


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.BtnHome.FillColor = Color.FromArgb(255, 110, 108);
            this.BtnHome.ForeColor = Color.White;
            this.BtnTeam.FillColor = Color.Transparent;
            this.BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            this.BtnProducts.FillColor = Color.Transparent;
            this.BtnProducts.ForeColor = Color.FromArgb(32, 22, 16);


            //Controls.Add(UserControls.HomeUC.Instance);
            //UserControls.HomeUC.Instance.Location = new Point(0, 100);
            //UserControls.HomeUC.Instance.BringToFront();

            if (!MainPanel.Controls.Contains(UserControls.HomeUC.Instance))
            {
   
                MainPanel.Controls.Add(UserControls.HomeUC.Instance);
                UserControls.HomeUC.Instance.BringToFront();
            }
            else
                UserControls.HomeUC.Instance.BringToFront();


        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            this.BtnHome.FillColor = Color.Transparent;
            this.BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            this.BtnTeam.FillColor = Color.FromArgb(255, 110, 108);
            this.BtnTeam.ForeColor = Color.White;
            this.BtnProducts.FillColor = Color.Transparent;
            this.BtnProducts.ForeColor = Color.FromArgb(32, 22, 16);

            //Controls.Add(UserControls.TeamUC.Instance);
            //UserControls.TeamUC.Instance.Location = new Point(0, 100);
            //UserControls.TeamUC.Instance.BringToFront();




            if (!MainPanel.Controls.Contains(UserControls.TeamUC.Instance))
            {
                MainPanel.Controls.Add(UserControls.TeamUC.Instance);
                UserControls.TeamUC.Instance.BringToFront();
            }
            else
                UserControls.TeamUC.Instance.BringToFront();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            this.BtnHome.FillColor = Color.Transparent;
            this.BtnHome.ForeColor = Color.FromArgb(32, 22, 16);
            this.BtnTeam.FillColor = Color.Transparent;
            this.BtnTeam.ForeColor = Color.FromArgb(32, 22, 16);
            this.BtnProducts.FillColor = Color.FromArgb(255, 110, 108);
            this.BtnProducts.ForeColor = Color.White;

            //Controls.Add(UserControls.ProductUC.Instance);
            //UserControls.ProductUC.Instance.Location = new Point(0, 100);
            //UserControls.ProductUC.Instance.BringToFront();

            if (!MainPanel.Controls.Contains(UserControls.ProductUC.Instance))
            {
                MainPanel.Controls.Add(UserControls.ProductUC.Instance);
                UserControls.ProductUC.Instance.BringToFront();
            }
            else
                UserControls.ProductUC.Instance.BringToFront();

        }

        private void PicLogo_Click(object sender, EventArgs e)
        {


        }
    }
}

