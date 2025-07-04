using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class GradeSubjectDal
    {
        public int AddGradeSubject(GradeSubject gradesubject)
        {
            string query = @"INSERT INTO grade_subject
                            (grade_id,subject_id,
                             created_at, created_by)
                            VALUES
                            (@gradeId, @subjectId, 
                             @createdAt, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradesubject.GradeId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = gradesubject.SubjectId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = gradesubject.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = gradesubject.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool DeleteGradeSubject(int gradeId,int subjectId)
        {
            string query = @"DELETE FROM grades_subject 
                             WHERE grade_id = @gradeId AND subject_id = @subjectId;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = subjectId }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
