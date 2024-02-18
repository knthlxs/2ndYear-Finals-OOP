using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalsOOP {
    public partial class MainForm : Form {
        RegForm regForm;
        ExerciseForm exerciseForm;
        CalculatorForm calculatorForm;

        public MainForm() {
            InitializeComponent();
        }

        // Confirmation for exiting the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show("Are you sure that you would like to close the window?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes) {
                this.Close();
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e) {
            // Prevents creating a new form if there is already an active registration form
            if (regForm == null || regForm.IsDisposed) {
                regForm = new RegForm(); 
                regForm.Show();
            } else {
                regForm.BringToFront();
            }
        }

        private void exerciseToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("\t\t! ! ! PLEASE READ ! ! !\n\nInstructions:\n\tYou will answer 10 random questions.\n\tYou need to finish the test within 30 seconds.\n\tYour score must be greater than or equal 7 to pass.\n\tIf your score is below 7 you will take again the quiz.\n\tIf you failed after 3 tries, the quiz will be closed.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            exerciseForm = new ExerciseForm();
            exerciseForm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e) {
            // Prevents creating a new form if there is already an active calculator
            if (calculatorForm == null || calculatorForm.IsDisposed) {
                calculatorForm = new CalculatorForm();
                calculatorForm.Show();
            } else {
                calculatorForm.BringToFront();
            }
        }

        // Confirmation for exiting the form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure that you would like to close the window?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("File saved!", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("File deleted!", "Delete File", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // Event for clicking the button
        private void buttonLogin_Click(object sender, EventArgs e) {
            if (!(textBoxUsernameL.Text == string.Empty || textBoxUsernameL.Text == "") && !(textBoxPasswordL.Text == string.Empty || textBoxPasswordL.Text == ""))
            {
                MessageBox.Show($"Welcome, {textBoxUsernameL.Text}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsernameL.Text = string.Empty;
                textBoxPasswordL.Text = string.Empty;
            }
        }
    }
}
