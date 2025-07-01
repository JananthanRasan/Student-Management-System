using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Students
{
    public partial class CreateStudentForm : Form
    {
        private StudentDal studentsDal = new StudentDal();
        public CreateStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int admissionNo = Convert.ToInt32(txtAdmissionNo.Text.Trim());
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string telephoneNo = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;
            DateTime enrollmentDate = dtpEnrollmentDate.Value.Date;
            int gradeid = cmbGrade.SelectedIndex != -1 ? Convert.ToInt32(cmbGrade.SelectedValue) : 0;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            var student = new Model.Student
            {
                FirstName = firstName,
                LastName = lastName,
                AdmissionNo = admissionNo,
                Phone = telephoneNo,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                EnrollmentDate = enrollmentDate,
                GradeId = gradeid,
                Gender = gender,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            studentsDal.AddStudent(student);
            clear();

        }

        private void clear()
        {
            txtAdmissionNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbGrade.SelectedIndex = -1;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CreateStudentForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
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
    }
}
