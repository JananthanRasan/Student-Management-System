using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class SubjectTeacherDal
    {
        public int AddTeacherSubject(SubjectTeacher subjectteacher)
        {
            string query = @"INSERT INTO subject_teacher
                            (teacher_id,subject_id,
                             created_at, created_by)
                            VALUES
                            (@teacherId, @subjectId, 
                             @createdAt, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = subjectteacher.TeacherId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = subjectteacher.SubjectId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = subjectteacher.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = subjectteacher.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool DeleteStudentSubject(int teacherId, int subjectId)
        {
            string query = @"DELETE FROM subject_teacher 
                             WHERE teacher_id = @teacherId AND subject_id = @subjectId;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = teacherId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = subjectId }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
