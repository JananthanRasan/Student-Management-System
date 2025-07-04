using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class StudentSubjectDal
    {
        public int AddStudentSubject(StudentSubject studentsubject)
        {
            string query = @"INSERT INTO student_subject
                            (student_id,subject_id,
                             created_at, created_by)
                            VALUES
                            (@studentId, @subjectId, 
                             @createdAt, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = studentsubject.StudentId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = studentsubject.SubjectId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = studentsubject.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = studentsubject.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool DeleteStudentSubject(int studentId, int subjectId)
        {
            string query = @"DELETE FROM student_subject 
                             WHERE student_id = @studentId AND subject_id = @subjectId;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = studentId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = subjectId }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
