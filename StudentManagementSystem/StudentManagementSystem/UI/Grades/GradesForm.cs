using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
using StudentManagementSystem.UI.GradeSubject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Grades
{
    public partial class GradesForm : Form
    {
        private GradeDal gradesDal = new GradeDal();
        public GradesForm()
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

        private void GradesForm_Load(object sender, EventArgs e)
        {
            DataTable gradesTable = gradesDal.GetAllGrades();
            dgvGrades.DataSource = gradesTable;
            dgvGrades.Columns["id"].HeaderText = "ID";
            dgvGrades.Columns["grade_name"].HeaderText = "Grade Name";
            dgvGrades.Columns["grade_order"].HeaderText = "Grade Order";
            dgvGrades.Columns["grade_color"].HeaderText = "Grade Color";
            dgvGrades.Columns["grade_group"].HeaderText = "Grade Group";
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblCount.Text = $"Total Grades: {dgvGrades.Rows.Count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GradesForm_Load(sender, e);
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            string gradeName = txtGradeName.Text.Trim();
            double gradeOrder = Convert.ToDouble(txtGradeOrder.Text.Trim());
            string gradeColor = txtGradeColor.Text.Trim();
            string gradeGroup = txtGradeGroup.Text.Trim();

            var grade = new Model.Grade
            {
                GradeName = gradeName,
                GradeOrder = gradeOrder,
                GradeColor = gradeColor,
                GradeGroup = gradeGroup,
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            gradesDal.AddGrade(grade);
            clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtGradeName.Clear();
            txtGradeOrder.Clear();
            txtGradeColor.Clear();
            txtGradeGroup.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);

            var grade = gradesDal.GetGradeById(gradeId);
            if (grade != null)
            {
                txtGradeName.Text = grade.GradeName;
                txtGradeOrder.Text = grade.GradeOrder.ToString();
                txtGradeColor.Text = grade.GradeColor;
                txtGradeGroup.Text = grade.GradeGroup;

            }
            else
            {
                MessageBox.Show("Subject not found.");
            }
            btnAddGrade.Visible = false;
            btnUpdate.Visible = true;
            btnReset.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gradeName = txtGradeName.Text;
            double gradeOrder = Convert.ToDouble(txtGradeOrder.Text);
            string gradeColor = txtGradeColor.Text;
            string gradeGroup = txtGradeGroup.Text;

            var grade = new Grade
            {
                GradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value),
                GradeName = gradeName,
                GradeOrder = gradeOrder,
                GradeColor = gradeColor,
                GradeGroup = gradeGroup,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };


            try
            {
                gradesDal.UpdateGrade(grade);
                MessageBox.Show("Grade details updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
            finally { 
                clear();
                btnAddGrade.Visible = true;
                btnUpdate.Visible = false;
                btnReset.Visible = true;
                GradesForm_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Do you want to delete the selected Grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int gradeid = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);
                gradesDal.DeleteGrade(gradeid);
                GradesForm_Load(sender, e);

                MessageBox.Show("Grade deleted successfully.");

            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to Add Subject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);

            GradeSubjectForm gradeSubjectForm = new GradeSubjectForm(gradeId);
            gradeSubjectForm.ShowDialog();
        }
    }
}
