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
    internal class TeacherDal
    {
        public DataTable GetAllTeachers()
        {
            string query = @"SELECT id, employment_id, first_name, last_name,
                        gender, nic_no, phone_no, email_id, address, date_of_birth, date_of_employment
                        FROM teachers ORDER BY last_name, first_name";

            return DbHelper.GetData(query);
        }


        public Teacher GetTeacherById(int teacherId)
        {
            string query = @"SELECT * FROM teachers WHERE id = @teacherId";

            var parameter = new MySqlParameter("@teacherId", MySqlDbType.Int32)
            {
                Value = teacherId
            };


            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;


            DataRow row = dt.Rows[0];
            return new Model.Teacher
            {
                TeacherId = Convert.ToInt32(row["id"]),
                EmploymentId = Convert.ToInt32(row["employment_id"]),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Gender = row["gender"].ToString(),
                NIC = row["nic_no"].ToString(),
                Phone = row["phone_no"].ToString(),
                Email = row["email_id"].ToString(),
                Address = row["address"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
                EmploymentDate = Convert.ToDateTime(row["date_of_employment"]),
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }


        public int AddTeacher(Teacher teacher)
        {
            string query = @"INSERT INTO teachers
                                (employment_id, first_name, last_name, gender, nic_no, phone_no, email_id, address, 
                                date_of_birth, date_of_employment, created_at, created_by)
                                VALUES (@employmentId, @firstName, @lastName, @gender, @nic, @phone, @email,
                                @address, @dob, @employmentDate, @createdAt, @createdBy);
                                SELECT LAST_INSERT_ID();";


            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@employmentId", MySqlDbType.Int32) { Value = teacher.EmploymentId },
            new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = teacher.FirstName },
            new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = teacher.LastName },
            new MySqlParameter("@gender", MySqlDbType.Enum) { Value = teacher.Gender },
            new MySqlParameter("@nic", MySqlDbType.VarChar) { Value = teacher.NIC },
            new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = teacher.Phone ?? (object)DBNull.Value },
            new MySqlParameter("@email", MySqlDbType.VarChar) { Value = teacher.Email ?? (object)DBNull.Value },
            new MySqlParameter("@address", MySqlDbType.VarChar) { Value = teacher.Address ?? (object)DBNull.Value },
            new MySqlParameter("@dob", MySqlDbType.Date) { Value = teacher.DateOfBirth },
            new MySqlParameter("@employmentDate", MySqlDbType.Date) { Value = teacher.EmploymentDate },
            new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = DateTime.Now },
            new MySqlParameter("@createdBy", MySqlDbType.Int32) { Value = teacher.CreatedBy }
            };


            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }


        public bool UpdateTeacher(Model.Teacher teacher)
        {
            string query = @"UPDATE teachers SET
                         employment_id = @employmentId,    
                         first_name = @firstName,
                         last_name = @lastName,
                         gender = @gender,
                         nic_no = @nic,
                         phone_no = @phone,  
                         email_id = @email, 
                         address = @address,
                         date_of_birth = @dob,
                         date_of_employment = @employmentDate,
                         updated_by = @updatedBy
                         WHERE id = @teacherId";


            var parameters = new MySqlParameter[]
            {
                 new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = teacher.TeacherId },
                 new MySqlParameter("@employmentId", MySqlDbType.Int32) { Value = teacher.EmploymentId },
                 new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = teacher.FirstName },
                 new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = teacher.LastName },
                 new MySqlParameter("@gender", MySqlDbType.Enum) { Value = teacher.Gender },
                 new MySqlParameter("@nic", MySqlDbType.VarChar) { Value = teacher.NIC },
                 new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = teacher.Phone ?? (object)DBNull.Value },
                 new MySqlParameter("@email", MySqlDbType.VarChar) { Value = teacher.Email ?? (object)DBNull.Value },
                 new MySqlParameter("@address", MySqlDbType.VarChar) { Value = teacher.Address ?? (object)DBNull.Value },
                 new MySqlParameter("@dob", MySqlDbType.Date) { Value = teacher.DateOfBirth },
                 new MySqlParameter("@employmentDate", MySqlDbType.Date) { Value = teacher.EmploymentDate },
                 new MySqlParameter("@updatedBy", MySqlDbType.Int32) { Value = teacher.UpdatedBy }
            };


            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool DeleteTeacher(int teacherId)
        {
            string query = "DELETE FROM teachers WHERE id = @teacherId";
            var parameter = new MySqlParameter("@teacherId", MySqlDbType.Int32)
            {
                Value = teacherId
            };
            return DbHelper.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
