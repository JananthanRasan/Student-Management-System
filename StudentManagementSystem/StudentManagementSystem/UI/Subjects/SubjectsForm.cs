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

namespace StudentManagementSystem.UI.Subjects
{
    public partial class SubjectsForm : Form
    {
        private SubjectDal subjectDal = new SubjectDal();
        public SubjectsForm()
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

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            DataTable subjectsTable = subjectDal.GetAllSubjects();
            dgvSubjects.DataSource = subjectsTable;
            dgvSubjects.Columns["id"].HeaderText = "ID";
            dgvSubjects.Columns["subject_name"].HeaderText = "Subject Name";
            dgvSubjects.Columns["subject_index"].HeaderText = "Suject Index";
            dgvSubjects.Columns["subject_order"].HeaderText = "Subject Order";
            dgvSubjects.Columns["subject_color"].HeaderText = "Subject Color";
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblCount.Text = $"Total Subjects: {dgvSubjects.Rows.Count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SubjectsForm_Load(sender,e);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();
            string subjectIndex = txtSubjectIndex.Text.Trim();
            double subjectOrder = Convert.ToDouble(txtSubjectOrder.Text.Trim());
            string subjectColor = txtSubjectColor.Text.Trim();

            var subject = new Model.Subject
            {
                SubjectName = subjectName,
                SubjectIndex = subjectIndex,
                SubjectOrder = subjectOrder,
                SubjectColor = subjectColor,
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            subjectDal.AddSubject(subject);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Do you want to delete the selected Subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int subjectId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["id"].Value);
                subjectDal.DeleteSubject(subjectId);
                SubjectsForm_Load(sender, e);

                MessageBox.Show("Subject deleted successfully.");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["id"].Value);

            var subject = subjectDal.GetSubjectById(subjectId);
            if (subject != null)
            {
                txtSubjectName.Text = subject.SubjectName;
                txtSubjectIndex.Text = subject.SubjectIndex;
                txtSubjectOrder.Text = subject.SubjectOrder.ToString();
                txtSubjectColor.Text = subject.SubjectColor;

            }
            else
            {
                MessageBox.Show("Subject not found.");
            }
            btnAddSubject.Visible = false;
            btnUpdate.Visible = true;
            btnReset.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();
            string subjectIndex = txtSubjectIndex.Text.Trim();
            double subjectOrder = Convert.ToDouble(txtSubjectOrder.Text);
            string subjectColor = txtSubjectColor.Text.Trim();

            var subject = new Subject
            {
                SubjectId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["id"].Value),
                SubjectName = subjectName,
                SubjectIndex = subjectIndex,
                SubjectOrder = subjectOrder,
                SubjectColor = subjectColor,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };


            try
            {
                subjectDal.UpdateSubject(subject);
                MessageBox.Show("Subject details updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
            finally
            {
                clear();
                btnAddSubject.Visible = true;
                btnUpdate.Visible = false;
                btnReset.Visible = true;
                SubjectsForm_Load(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtSubjectName.Clear();
            txtSubjectIndex.Clear();
            txtSubjectOrder.Clear();
            txtSubjectColor.Clear();
        }
    }
}
