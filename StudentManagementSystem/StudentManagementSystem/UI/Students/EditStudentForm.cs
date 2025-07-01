using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Students
{
    public partial class EditStudentForm : Form
    {
        private int id;
        private StudentDal studentsDal = new StudentDal();
        public EditStudentForm(int studentID)
        {
            InitializeComponent();
            this.id = studentID;
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            LoadGrades();

            var student = studentsDal.GetStudentById(id);
            if (student != null)
            {
                txtAdmissionNo.Text =student.AdmissionNo.ToString();
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtPhoneNo.Text = student.Phone;
                txtEmail.Text = student.Email;
                txtAddress.Text = student.Address;
                dtpDOB.Value = student.DateOfBirth;
                dtpEnrollmentDate.Value = student.EnrollmentDate;
                rdoMale.Checked = student.Gender == "Male";
                rdoFemale.Checked = student.Gender == "Female";
                cmbGrade.SelectedValue = student.GradeId;
                lblHead.Text = $"{student.FirstName}'s Edit";

            }
            else
            {
                MessageBox.Show("Student not found.");
                this.Close();
            }
        }

        private void LoadGrades()
        {
            var gradesDal = new GradeDal();
            DataTable gradeTable = gradesDal.GetAllGrades();

            cmbGrade.DataSource = gradeTable;
            cmbGrade.DisplayMember = "grade_name";
            cmbGrade.ValueMember = "id";
            cmbGrade.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int admissionNo = Convert.ToInt32(txtAdmissionNo.Text.Trim());
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNo = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;
            DateTime enrollmentDate = dtpEnrollmentDate.Value.Date;
            int gradeid = cmbGrade.SelectedIndex != -1 ? Convert.ToInt32(cmbGrade.SelectedValue) : 0;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            var student = new Student
            {
                StudentId = id,
                FirstName = firstName,
                LastName = lastName,
                AdmissionNo = admissionNo,
                Phone = phoneNo,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                EnrollmentDate = enrollmentDate,
                GradeId = gradeid,
                Gender = gender,
                UpdatedBy = "1"
            };


            try
            {
                studentsDal.UpdateStudent(student);
                MessageBox.Show("Student details updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }
    }
}
