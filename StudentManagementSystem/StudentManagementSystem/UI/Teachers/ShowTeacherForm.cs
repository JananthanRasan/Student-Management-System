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
    public partial class ShowTeacherForm : Form
    {
        private int id;
        private TeacherDal teacherDal = new TeacherDal();
        public ShowTeacherForm(int teacherId)
        {
            InitializeComponent();
            this.id= teacherId;
        }

        private void ShowTeacherForm_Load(object sender, EventArgs e)
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
                txtDOB.Text = teacher.DateOfBirth.ToString();
                txtEmploymentDate.Text = teacher.EmploymentDate.ToString();
                txtGender.Text = teacher.Gender.ToString();
                lblHead.Text = $"{teacher.FirstName}'s Details";

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
    }
}
