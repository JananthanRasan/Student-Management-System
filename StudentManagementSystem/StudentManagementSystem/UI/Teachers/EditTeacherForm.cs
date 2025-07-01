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

namespace StudentManagementSystem.UI.Teachers
{
    public partial class EditTeacherForm : Form
    {
        private int id;
        private TeacherDal teacherDal = new TeacherDal();
        public EditTeacherForm(int teacherId)
        {
            InitializeComponent();
            this.id = teacherId;
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            var teacher = teacherDal.GetTeacherById(id);
            if (teacher != null)
            {
                txtEmploymentId.Text = teacher.EmploymentId.ToString();
                txtFirstName.Text = teacher.FirstName;
                txtLastName.Text = teacher.LastName;
                txtNIC.Text = teacher.NIC;
                txtPhoneNo.Text = teacher.Phone;
                txtEmail.Text = teacher.Email;
                txtAddress.Text = teacher.Address;
                dtpDOB.Value = teacher.DateOfBirth;
                dtpEmploymentDate.Value = teacher.EmploymentDate;
                rdoMale.Checked = teacher.Gender == "Male";
                rdoFemale.Checked = teacher.Gender == "Female";
                lblHead.Text = $"{teacher.FirstName}'s Edit";

            }
            else
            {
                MessageBox.Show("Teacher not found.");
                this.Close();
            }
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
            int employmentId = Convert.ToInt32(txtEmploymentId.Text.Trim());
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string phoneNo = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;
            DateTime employmentDate = dtpEmploymentDate.Value.Date;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            var teacher = new Teacher
            {
                TeacherId = id,
                FirstName = firstName,
                LastName = lastName,
                NIC = nic,
                EmploymentId = employmentId,
                Phone = phoneNo,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                EmploymentDate = employmentDate,
                Gender = gender,
                UpdatedBy = "1"
            };


            try
            {
                teacherDal.UpdateTeacher(teacher);
                MessageBox.Show("Teacher details updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Teacher: " + ex.Message);
            }
        }
    }
}
