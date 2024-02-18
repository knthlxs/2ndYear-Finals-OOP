using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsOOP {
    public partial class RegForm : Form {
        public RegForm() {
            InitializeComponent();
        }

        private void RegForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure that you would like to close the registration form?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                e.Cancel = true;
            }
        }



        public bool validIntegers(string input) {

            bool valid = true;
            for (int i = 0; i < input.Length; i++) {
                if (!char.IsDigit(input[i])) {
                    valid = false;
                } else {
                    valid = true;
                }
            }
            return valid;

        }
        public bool validString(string input) {

            bool valid = true;
            for (int i = 0; i < input.Length; i++) {
                if (!char.IsDigit(input[i])) {
                    valid = false;
                } else {
                    valid = true;
                }
            }
            return valid;

        }

        public void isCompleted() {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtMiddleName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(dateBirth.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(cbGender.Text) || string.IsNullOrEmpty(txtNationality.Text) || string.IsNullOrEmpty(txtReligion.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtBlock.Text) || string.IsNullOrEmpty(txtCountry.Text) || string.IsNullOrEmpty(txtBarangay.Text) || string.IsNullOrEmpty(txtPostal.Text) || string.IsNullOrEmpty(txtMunicipality.Text) || string.IsNullOrEmpty(txtCourse.Text) || string.IsNullOrEmpty(txtAcadYear.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtSection.Text) || string.IsNullOrEmpty(txtFatherName.Text) || string.IsNullOrEmpty(dateFatherBirth.Text) || string.IsNullOrEmpty(txtFatherOccupation.Text) || string.IsNullOrEmpty(txtFatherAge.Text) || string.IsNullOrEmpty(txtFatherContact.Text) || string.IsNullOrEmpty(txtMotherName.Text) || string.IsNullOrEmpty(dateMotherBirth.Text) || string.IsNullOrEmpty(txtMotherOccupation.Text) || string.IsNullOrEmpty(txtMotherAge.Text) || string.IsNullOrEmpty(txtMotherContact.Text) || string.IsNullOrEmpty(txtElemSchool.Text) || string.IsNullOrEmpty(dateElemGrad.Text) || string.IsNullOrEmpty(txtElemAdviser.Text) || string.IsNullOrEmpty(txtJuniorSchool.Text) || string.IsNullOrEmpty(dateJuniorGrad.Text) || string.IsNullOrEmpty(txtJuniorAdviser.Text) || string.IsNullOrEmpty(txtSeniorSchool.Text) || string.IsNullOrEmpty(dateSeniorGrad.Text) || string.IsNullOrEmpty(txtSeniorAdviser.Text) || string.IsNullOrEmpty(txtCollegeSchool.Text) || string.IsNullOrEmpty(dateCollegeGrad.Text) || string.IsNullOrEmpty(txtCollegeAdviser.Text)) {
                MessageBox.Show("Please complete all required fields.");

            } else {
                lblTitle.Text = "STUDENT INFORMATION SUMMARY";
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panelStudInfoS.Visible = true;
                panelGuardianInfoS.Visible = true;
                panelEducAttainS.Visible = true;
               lblFirstNameS.Text = txtFirstName.Text;
                lblMiddleNameS.Text = txtMiddleName.Text;
                lblSurnameS.Text = txtSurname.Text;
                lblBirthDateS.Text = dateBirth.Text;
                lblAgeS.Text = txtAge.Text;
                lblGenderS.Text = cbGender.Text;
                lblNationalityS.Text = txtNationality.Text;
                lblReligionS.Text = txtReligion.Text;
                lblEmailS.Text = txtEmail.Text;
                lblContactS.Text = txtContact.Text;

                lblBlockS.Text = txtBlock.Text;
                lblBarangayS.Text = txtBarangay.Text;
                lblMunicipalityS.Text = txtMunicipality.Text;
                lblCountryS.Text = txtCountry.Text;
                lblPostalS.Text = txtPostal.Text;
                
                lblCourseS.Text = txtCourse.Text;
                lblAcadYearS.Text = txtAcadYear.Text;
                lblYearS.Text = txtYear.Text;
                lblSectionS.Text = txtSection.Text;

                lblFatherNameS.Text = txtFatherName.Text;
                lblFatherOccupationS.Text = txtFatherOccupation.Text;
                lblFatherContactS.Text = txtFatherContact.Text;
                lblFatherBirthS.Text = dateFatherBirth.Text;
                lblFatherAgeS.Text = lblFatherAge.Text;

                lblMotherNameS.Text = txtMotherName.Text;
                lblMotherOccupationS.Text = txtMotherOccupation.Text;
                lblMotherContactS.Text = txtMotherContact.Text;
                lblMotherBirthS.Text = dateMotherBirth.Text;
                lblMotherAgeS.Text = lblMotherAge.Text;

                lblElemSchoolS.Text = txtElemSchool.Text;
                lblElemGradS.Text = dateElemGrad.Text;
                lblElemAdvS.Text = txtElemAdviser.Text;

                lblJuniorSchoolS.Text = txtJuniorSchool.Text;
                lblJuniorGradS.Text = dateJuniorGrad.Text;
                lblJuniorAdvS.Text = txtJuniorAdviser.Text;

                lblSeniorSchoolS.Text = txtSeniorSchool.Text;
                lblSeniorGradS.Text = dateSeniorGrad.Text;
                lblSeniorAdvS.Text = txtSeniorAdviser.Text;

                lblCollegeSchoolS.Text = txtCollegeSchool.Text;
                lblCollegeGradS.Text = dateCollegeGrad.Text;
                lblCollegeAdvS.Text = txtCollegeAdviser.Text;

            }
        }


        private void btnSubmit_Click(object sender, EventArgs e) {
            try { 
                if (validIntegers(txtContact.Text) && validIntegers(txtFatherContact.Text) && validIntegers(txtMotherContact.Text) && validIntegers(txtContact.Text)) {

                    if (validIntegers(txtAge.Text) && validIntegers(txtFatherAge.Text) && validIntegers(txtMotherAge.Text)) {

                        isCompleted();

                    } else {
                        throw new ValidAgeException();
                    }

                } else {        
                   
                    throw new ValidContactException();
                }
            } catch (ValidAgeException ex) {
                MessageBox.Show(ex.Message + "\n\nPlease input an integer for age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ValidContactException ex) {
                MessageBox.Show(ex.Message + "\n\nPlease input an integer for contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegForm_Load(object sender, EventArgs e) {
            lblTitle.Text = "STUDENT REGISTRATION FORM";
            panelStudInfoS.Visible = false;
            panelGuardianInfoS.Visible = false;
            panelEducAttainS.Visible = false;
        }
        
    }
}
