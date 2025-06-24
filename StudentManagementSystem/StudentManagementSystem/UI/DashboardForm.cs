using StudentManagementSystem.UI.Grades;
using StudentManagementSystem.UI.Students;
using StudentManagementSystem.UI.Subjects;
using StudentManagementSystem.UI.Teachers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentManagementSystem.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudentForm frm = new CreateStudentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStudentsForm frm = new ListStudentsForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudentForm frm = new EditStudentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentForm frm = new ShowStudentForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTeacherForm frm = new CreateTeacherForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void teacherListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTeachersForm frm = new ListTeachersForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTeacherForm frm = new EditTeacherForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void showTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeacherForm frm = new ShowTeacherForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gRADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesForm frm = new GradesForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sUBJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm frm = new SubjectsForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
