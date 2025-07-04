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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementSystem.UI.GradeSubject
{
    public partial class GradeSubjectForm : Form
    {
        int gradeId;
        GradeDal gradeDal = new GradeDal();
        SubjectDal subjectDal = new SubjectDal();
        public GradeSubjectForm(int gradeId)
        {
            InitializeComponent();
            this.gradeId = gradeId;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GradeSubjectForm_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(lvwStudents.Text);
        }

        private void GradeSubjectForm_Load(object sender, EventArgs e)
        {
            var grade = gradeDal.GetGradeById(gradeId);
            if (grade != null)
            {

                lblHead.Text = $"{grade.GradeName}'s Subjects";

            }
            else
            {
                MessageBox.Show("Grade not found.");
            }

            lvwStudents.Items.Clear();
            lvwStudents.Columns.Clear();
            lvwStudents.View = View.Details;

            DataTable dt = subjectDal.GetAllSubjects();


            foreach (DataColumn column in dt.Columns)
            {
                
                lvwStudents.Columns.Add(column.ColumnName, 100, HorizontalAlignment.Left);
            }

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());

                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    
                    item.SubItems.Add(row[i].ToString());
                }

                lvwStudents.Items.Add(item);
            }

            foreach (ColumnHeader column in lvwStudents.Columns)
            {
                column.Width = -2; // Auto resize based on content
            }



        }
    }
}
