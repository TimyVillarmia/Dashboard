using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity78_Group2_CS201
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }


        private void picCountry_BackgroundImageChanged(object sender, EventArgs e)
        {

   

        }

 

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;

            double num = 0.0;

         if (double.TryParse(input, out num))   
            {
                double userInput = Convert.ToDouble(txtInput1.Text);


                if (comboCurrency1.Text == "PHP" && comboCurrency2.Text == "USD")
                {
                    double result = userInput * 0.019;
                    txtResult.Text = Convert.ToString(result);
                }
                if (comboCurrency1.Text == "USD" && comboCurrency2.Text == "PHP")
                {
                    double result = userInput * 52.38;
                    txtResult.Text = Convert.ToString(result);
                }
                if (comboCurrency1.Text == "PHP" && comboCurrency2.Text == "JPY")
                {
                    double result = userInput * 2.47;
                    txtResult.Text = Convert.ToString(result);
                }
                if (comboCurrency1.Text == "JPY" && comboCurrency2.Text == "PHP")
                {
                    double result = userInput * 0.41;
                    txtResult.Text = Convert.ToString(result);
                }
                if (comboCurrency1.Text == "JPY" && comboCurrency2.Text == "USD")
                {
                    double result = userInput * 0.0077;
                    txtResult.Text = Convert.ToString(result);
                }
                if (comboCurrency1.Text == "USD" && comboCurrency2.Text == "JPY")
                {
                    double result = userInput * 129.27;
                    txtResult.Text = Convert.ToString(result);
                }
    
            }
         else  
            {
                MessageBox.Show("Please enter valid input");
            }
  

        }

        private void comboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changing picturebox depeding on selected index from combobox

            int select = comboCurrency1.SelectedIndex; // creating int variable
            switch (select)
            {
                case 0:
                    picCountry1.Image = Image.FromFile(@"Images\PHP.png");
                    break;
                case 1:
                    picCountry1.Image = Image.FromFile(@"Images\JPY.png");
                    break;
                case 2:
                    picCountry1.Image = Image.FromFile(@"Images\USD.png");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //adding item for  comboCurrency1
            comboCurrency1.Items.Add("PHP");
            comboCurrency1.Items.Add("JPY");
            comboCurrency1.Items.Add("USD");
            //adding item for  comboCurrency2
            comboCurrency2.Items.Add("PHP");
            comboCurrency2.Items.Add("JPY");
            comboCurrency2.Items.Add("USD");

            //for default value
            comboCurrency1.SelectedIndex = 0; 
            comboCurrency2.SelectedIndex = 1; 
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // changing picturebox depeding on selected index from combobox

            int select = comboCurrency2.SelectedIndex; // creating int variable 
            switch (select)
            {
                case 0: 
                    picCountry2.Image = Image.FromFile(@"Images\PHP.png");
                    break;
                case 1:
                    picCountry2.Image = Image.FromFile(@"Images\JPY.png");
                    break;
                case 2:
                    picCountry2.Image = Image.FromFile(@"Images\USD.png");
                    break;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this app");
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Clear();
            txtResult.Clear();
            
        }
    }
}
