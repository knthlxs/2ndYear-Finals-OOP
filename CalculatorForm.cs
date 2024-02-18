using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FinalsOOP {
    public partial class CalculatorForm : Form {
        string operation = "";
        double result = 0;
        bool operatorClicked = false, equalsClicked = false;
        public CalculatorForm() {
            InitializeComponent();
        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e) {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            // Ignore the non-digit or non-decimal point key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') {
                e.Handled = true;  
            }
            // Ignore the additional decimal point
            if (e.KeyChar == '.' && textbox.Text.Contains(".")) {
                e.Handled = true;  
            }
        }

        // Reset to 0 if equals button is clicked
        private void resetValue() {
            if (equalsClicked) {
                result = 0;
                txtOutput.Text = result.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            
            resetValue();

            if ((txtOutput.Text == "0") || operatorClicked) {
                txtOutput.Clear();
            }

            if (button.Text.Equals(".") && txtOutput.Text.Contains(".")) {
                // Ignore the click on the decimal button if it already exists in the textbox
                return;
            }

            txtOutput.Text += button.Text; // Display the button cliked to the output textbox
            operatorClicked = false;
            equalsClicked = false;
        }

        // Event when user click +, -, *, / operation
        private void ope_click(object sender, EventArgs e) {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            
            resetValue(); // Resets the value to 0
           
            if (result != 0) {
                btnEquals.PerformClick();  // Perform what equals click button do if the output is not = to 0
                operation = button.Text;
                operatorClicked = true;
                
                lblProcess.Text = result.ToString() + " " + operation;
            } else {
                operation = button.Text;
                result = Convert.ToDouble(txtOutput.Text); // Store the first number to result
                operatorClicked = true;

                if (result != 0) {
                    lblProcess.Text = result.ToString() + " " + operation; // If the output is not 0 continue the process
                } else {
                    lblProcess.Text = string.Empty; // Clear the process if the result resets to 0
                }
            }
            equalsClicked = false;
        }

        // Clear per character/digit
        private void btnClearEntry_Click(object sender, EventArgs e) {
            if (txtOutput.Text.Length != 1) {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            } else {
                txtOutput.Text = "0";
            }
        }

        // Reset all values
        private void btnClearAll_Click(object sender, EventArgs e) {
            lblProcess.Text = "";
            result = 0;
            txtOutput.Text = result.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e) {
            // To prevent performing the operation when the user click the equals button again
            if (equalsClicked) {
                return;
            }

            equalsClicked = true;
            operatorClicked = false;
            double num = Convert.ToDouble(txtOutput.Text); // Variable for 2nd to succeeding numbers
            double output = 0; 
            bool calculationSuccessful = false;

            try {
                // Perform operation based from the clicked operation
                switch (operation) {
                    case "+": {
                        output = (result + num);
                        break;
                    }
                    case "-": {
                        output = (result - num);
                        break;
                    }
                    case "*": {
                        output = (result * num);
                        break;
                    }
                    case "/": {
                        if (num == 0) {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        output = (result / num);
                        break;
                    }
                    default:
                    break;
                }
                    calculationSuccessful = true;
            } catch (DivideByZeroException ex) {
                txtOutput.Text = ex.Message;
            } catch (Exception ex) {
                txtOutput.Text = "An error occurred: " + ex.Message;
            }

            // If no exception occured
            if (calculationSuccessful) {
                result = output; // The value from the output variable will be stored in result so that you cab perform correct calculations simultaneously
                lblProcess.Text = "";
                txtOutput.Text = output.ToString();
            }
        }
    }
}
