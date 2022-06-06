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
    public partial class TeamUC : UserControl
    {
        private static TeamUC _instance;
        public static TeamUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeamUC();
                return _instance;
            }
        }
        public TeamUC()
        {
            InitializeComponent();


            
        }

        bool picboxclick = true;
        string linklabel = "";




        private void picbox1_Click(object sender, EventArgs e)
        {
            
            if (picboxclick == true)
            {
                lblName.Text = "Anzel Ybañez";
                lblText.Visible = false;
                linkFacebook.Text = "https://www.facebook.com/anzel.ybanez.5";
                picboxclick = false;
                linklabel = linkFacebook.Text;
            }
            else
            {
                lblName.Text = "Our Story";
                lblText.Visible = true;
                picboxclick = true;
            }

        }

        private void picbox2_Click(object sender, EventArgs e)
        {
         
            if (picboxclick == true)
            {
                lblName.Text = "Timy Villarmia";
                lblText.Visible = false;
                linkFacebook.Text = "https://www.facebook.com/VillarmiaTimy/";
                picboxclick = false;
                linklabel = linkFacebook.Text;
            }
            else
            {
                lblName.Text = "Our Story";
                lblText.Visible = true;
                picboxclick = true;
            }
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
     
            if (picboxclick == true)
            {
                lblName.Text = "Chelo Angelica Daguplo";
                lblText.Visible = false;
                linkFacebook.Text = "https://www.facebook.com/chelo.daguplo";
                picboxclick = false;
                linklabel = linkFacebook.Text;
            }
            else
            {
                lblName.Text = "Our Story";
                lblText.Visible = true;
                picboxclick = true;
            }
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
   
            if (picboxclick == true)
            {
                lblName.Text = "Chevy Joe Gades Talisaysay";
                lblText.Visible = false;
                linkFacebook.Text = "https://www.facebook.com/chivibot";
                picboxclick = false;
                linklabel = linkFacebook.Text;
            }
            else
            {
                lblName.Text = "Our Story";
                lblText.Visible = true;
                picboxclick = true;
            }
        }

        private void picbox5_Click(object sender, EventArgs e)
        {

            if (picboxclick == true)
            {
                lblName.Text = "Ginelyn Lucena";
                lblText.Visible = false;
                linkFacebook.Text = "https://www.facebook.com/ginelyn.lucena";
                picboxclick = false;
                linklabel = linkFacebook.Text;
            }
            else
            {
                lblName.Text = "Our Story";
                lblText.Visible = true;
                picboxclick = true;

            }

        }

        private void linkFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linklabel);
        }


    }
}
