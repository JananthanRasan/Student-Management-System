using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\R.Jananthan\Documents\testing.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO Enrollments(StudentID, StudentName, CourseCode, CourseName, Semester) VALUES ('{txtStudentId.Text}', '{txtStudentName.Text}','{txtCourseCode.Text}','{txtCourseName.Text}','{txtSemester.Text}')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("insert successful");
            view();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            view();
        }

        private void view()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Enrollments", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM Enrollments WHERE StudentID={txtStudentId.Text}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("delete successful");
            view();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE Enrollments SET StudentName = '{txtStudentName.Text}', CourseCode = '{txtCourseCode.Text}', CourseName = '{txtCourseName.Text}', Semester = '{txtSemester.Text}' WHERE StudentID={txtStudentId.Text}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update successful");
            view();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            view();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Enrollments WHERE StudentID = '{txtStudentId.Text}' OR StudentName = '{txtStudentName.Text}'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
