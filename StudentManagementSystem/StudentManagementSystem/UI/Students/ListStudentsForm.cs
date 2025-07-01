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
    public partial class ListStudentsForm : Form
    {
        private StudentDal studentsDal = new StudentDal();
        public ListStudentsForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);

            EditStudentForm editStudentForm = new EditStudentForm(studentId);
            editStudentForm.ShowDialog();
        }

        private void ListStudentsForm_Load(object sender, EventArgs e)
        {
            DataTable studentsTable = studentsDal.GetAllStudents();
            dgvStudents.DataSource = studentsTable;
            dgvStudents.Columns["id"].HeaderText = "ID";
            dgvStudents.Columns["admission_no"].HeaderText = "Admission No";
            dgvStudents.Columns["first_name"].HeaderText = "First Name";
            dgvStudents.Columns["last_name"].HeaderText = "Last Name";
            dgvStudents.Columns["gender"].HeaderText = "Gender";
            dgvStudents.Columns["phone_no"].HeaderText = "Telephone No";
            dgvStudents.Columns["email_id"].HeaderText = "Email ID";
            dgvStudents.Columns["address"].HeaderText = "Address";
            dgvStudents.Columns["date_of_birth"].HeaderText = "Date of Birth";
            dgvStudents.Columns["date_of_enrollment"].HeaderText = "Date of Enrollment";
            dgvStudents.Columns["grade_id"].HeaderText = "Grade ID";
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblCount.Text = $"Total Students: {dgvStudents.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListStudentsForm_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateStudentForm createStudentsForm = new CreateStudentForm();
            createStudentsForm.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Do you want to delete the selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
                studentsDal.DeleteStudent(studentId);
                ListStudentsForm_Load(sender, e);

                MessageBox.Show("Student deleted successfully.");

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
            ShowStudentForm showStudentForm = new ShowStudentForm(id);
            showStudentForm.ShowDialog();
        }
    }
}
