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

namespace StudentManagementSystem.UI.Teachers
{
    public partial class CreateTeacherForm : Form
    {
        private TeacherDal teachersDal = new TeacherDal();
        public CreateTeacherForm()
        {
            InitializeComponent();
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

        private void clear()
        {
            txtEmploymentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int employmentId = Convert.ToInt32(txtEmploymentId.Text.Trim());
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string telephoneNo = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;
            DateTime employmentDate = dtpEmploymentDate.Value.Date;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            var teacher = new Model.Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                EmploymentId = employmentId,
                NIC = nic,
                Phone = telephoneNo,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                EmploymentDate = employmentDate,
                Gender = gender,
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            teachersDal.AddTeacher(teacher);
            clear();
        }
    }
}
