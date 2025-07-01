using StudentManagementSystem.DAL;
using StudentManagementSystem.UI.Students;
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
    public partial class ListTeachersForm : Form
    {
        private TeacherDal TeacherDal = new TeacherDal();
        public ListTeachersForm()
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

        private void ListTeachersForm_Load(object sender, EventArgs e)
        {
            DataTable teachersTable = TeacherDal.GetAllTeachers();
            dgvTeachers.DataSource = teachersTable;
            dgvTeachers.Columns["id"].HeaderText = "ID";
            dgvTeachers.Columns["employment_id"].HeaderText = "Employment ID";
            dgvTeachers.Columns["first_name"].HeaderText = "First Name";
            dgvTeachers.Columns["last_name"].HeaderText = "Last Name";
            dgvTeachers.Columns["gender"].HeaderText = "Gender";
            dgvTeachers.Columns["nic_no"].HeaderText = "NIC";
            dgvTeachers.Columns["phone_no"].HeaderText = "Telephone No";
            dgvTeachers.Columns["email_id"].HeaderText = "Email ID";
            dgvTeachers.Columns["address"].HeaderText = "Address";
            dgvTeachers.Columns["date_of_birth"].HeaderText = "Date of Birth";
            dgvTeachers.Columns["date_of_employment"].HeaderText = "Date of Employment";
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblCount.Text = $"Total Teachers: {dgvTeachers.Rows.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateTeacherForm createTeacherForm = new CreateTeacherForm();
            createTeacherForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListTeachersForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Do you want to delete the selected teacher?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
                TeacherDal.DeleteTeacher(teacherId);
                ListTeachersForm_Load(sender, e);

                MessageBox.Show("Student deleted successfully.");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);

            EditTeacherForm editTeacherForm = new EditTeacherForm(teacherId);
            editTeacherForm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to View.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
            ShowTeacherForm showTeacherForm = new ShowTeacherForm(id);
            showTeacherForm.ShowDialog();
        }
    }
}
