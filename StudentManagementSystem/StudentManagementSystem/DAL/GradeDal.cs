using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class GradeDal
    {
        public DataTable GetAllGrades()
        {
            string query = @"SELECT 
                        id, grade_name, grade_order, grade_color, grade_group
                     FROM grades
                     ORDER BY grade_order";

            return DbHelper.GetData(query);
        }

        public Grade GetGradeById(int gradeId)
        {
            string query = "SELECT * FROM grades WHERE id = @gradeId";
            var parameter = new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Grade
            {
                GradeId = Convert.ToInt32(row["id"]),
                GradeName = row["grade_name"].ToString(),
                GradeOrder = Convert.ToDouble(row["grade_order"]),
                GradeColor = row["grade_color"].ToString(),
                GradeGroup = row["grade_group"].ToString(),

            };
        }

        public int AddGrade(Grade grade)
        {
            string query = @"INSERT INTO grades
                            (grade_name, grade_order, grade_color, grade_group,
                             created_at, created_by)
                            VALUES
                            (@gradeName, @gradeOrder, @gradeColor, @gradeGroup,
                             @createdAt, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeName", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@gradeOrder", MySqlDbType.Double) { Value = grade.GradeOrder },
                new MySqlParameter("@gradeColor", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@gradeGroup", MySqlDbType.VarChar) { Value = grade.GradeGroup },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = grade.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = grade.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateGrade(Grade grade)
        {
            string query = @"UPDATE grades SET
                                grade_name = @gradeName,
                                grade_order = @gradeOrder,
                                grade_color = @gradeColor,
                                grade_group = @gradeGroup,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @gradeid";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeid", MySqlDbType.Int32) { Value = grade.GradeId },
                new MySqlParameter("@gradeName", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@gradeOrder", MySqlDbType.Double) { Value = grade.GradeOrder },
                new MySqlParameter("@gradeColor", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@gradeGroup", MySqlDbType.VarChar) { Value = grade.GradeGroup },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = grade.UpdatedAt },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = grade.UpdatedBy ?? "" }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteGrade(int gradeId)
        {
            string query = @"DELETE FROM grades 
                             WHERE id = @gradeId;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
