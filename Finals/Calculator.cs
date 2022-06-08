using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity56_Group2_CS201
{
    public partial class Calculator : Form
    {
        double operand1;
        string operation;
        public Calculator()
        {
            InitializeComponent();
           
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput1.Text, out num);

            if (txtInput1.Text == String.Empty && txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");

               
            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                operand1 = Convert.ToDouble(txtInput1.Text);
                operation = "%";
                lblInterpreter.Text = txtInput1.Text + " " + operation;
            }
    
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput1.Text, out num);

            if (txtInput1.Text == String.Empty && txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");


            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                operand1 = Convert.ToDouble(txtInput1.Text);
                operation = "/";
                lblInterpreter.Text = txtInput1.Text + " " + operation;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
            lblInterpreter.Text = "";
            lblResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput1.Text, out num);

            if (txtInput1.Text == String.Empty && txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");


            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                operand1 = Convert.ToDouble(txtInput1.Text);
                operation = "*";
                lblInterpreter.Text = txtInput1.Text + " " + operation;
            }
   
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput1.Text, out num);

            if (txtInput1.Text == String.Empty && txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");


            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                operand1 = Convert.ToDouble(txtInput1.Text);
                operation = "-";
                lblInterpreter.Text = txtInput1.Text + " " + operation;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput1.Text, out num);

            if (txtInput1.Text == String.Empty && txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");


            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                operand1 = Convert.ToDouble(txtInput1.Text);
                operation = "+";
                lblInterpreter.Text = txtInput1.Text + " " + operation;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this application");
            this.Close();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            double num = 0;
            bool isNumber = false;

            isNumber = double.TryParse(txtInput2.Text, out num);

            if (txtInput2.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid input");


            }
            else if (isNumber == false)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else
            {
                double operand2;
                double result;

                operand2 = Convert.ToDouble(txtInput2.Text);

                lblInterpreter.Text = txtInput1.Text + " " + operation + " " + txtInput2.Text;

                if (operation == "+")
                {
                    result = (operand1 + operand2);
                    lblResult.Text = Convert.ToString(result);
                }
                if (operation == "-")
                {
                    result = (operand1 - operand2);
                    lblResult.Text = Convert.ToString(result);
                }
                if (operation == "*")
                {
                    result = (operand1 * operand2);
                    lblResult.Text = Convert.ToString(result);
                }
                if (operation == "%")
                {
                    result = (operand1 % operand2);
                    lblResult.Text = Convert.ToString(result);
                }
                if (operation == "/")
                {
                    if (operand2 == 0)
                    {
                        lblResult.Text = "Undefine";
                    }
                    else
                    {
                        result = (operand1 / operand2);
                        lblResult.Text = Convert.ToString(result);
                    }
                }
            }
            
        }   
    }
}
