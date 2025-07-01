using StudentManagementSystem.DAL;
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

    public partial class ShowStudentForm : Form
    {
        private int id;
        private StudentDal studentsDal = new StudentDal();
        public ShowStudentForm(int studentId)
        {
            InitializeComponent();
            this.id = studentId;
        }

        private void ShowStudentForm_Load(object sender, EventArgs e)
        {
            var student = studentsDal.GetStudentById(id);
            if (student != null)
            {
                txtAdmissionNo.Text = student.AdmissionNo.ToString();
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtPhoneNo.Text = student.Phone;
                txtEmail.Text = student.Email;
                txtAddress.Text = student.Address;
                txtDOB.Text = student.DateOfBirth.ToString();
                txtEnrollmentDate.Text = student.EnrollmentDate.ToString();
                txtGender.Text = student.Gender.ToString();
                txtGrade.Text = student.GradeId.ToString();
                lblHead.Text = $"{student.FirstName}'s Edit";

            }
            else
            {
                MessageBox.Show("Student not found.");
                this.Close();
            }
        }
    }
}
