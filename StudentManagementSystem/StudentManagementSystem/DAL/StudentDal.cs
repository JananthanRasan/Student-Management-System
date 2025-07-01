using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class StudentDal
    {
        public DataTable GetAllStudents()
        {
            string query = @"SELECT id, admission_no, first_name, last_name,
                        gender, phone_no, email_id, address, date_of_birth, date_of_enrollment, grade_id
                        FROM students ORDER BY last_name, first_name";

            return DbHelper.GetData(query);
        }


        public Student GetStudentById(int studentId)
        {
            string query = @"SELECT * FROM students WHERE id = @studentId";

            var parameter = new MySqlParameter("@studentId", MySqlDbType.Int32)
            {
                Value = studentId
            };


            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;


            DataRow row = dt.Rows[0];
            return new Model.Student
            {
                StudentId = Convert.ToInt32(row["id"]),
                AdmissionNo = Convert.ToInt32(row["admission_no"]),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Gender = row["gender"].ToString(),
                Phone = row["phone_no"].ToString(),
                Email = row["email_id"].ToString(),
                Address = row["address"].ToString(),
                GradeId = Convert.ToInt32(row["grade_id"]),
                DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
                EnrollmentDate = Convert.ToDateTime(row["date_of_enrollment"]),
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }


        public int AddStudent(Student student)
        {
            string query = @"INSERT INTO students
                                (admission_no, first_name, last_name, gender, phone_no, email_id,grade_id, address, 
                                date_of_birth, date_of_enrollment, created_at, created_by)
                                VALUES (@admissionNo, @firstName, @lastName, @gender, @phone, @email, @gradeid,
                                @address, @dob, @enrollmentDate, @createdAt, @createdBy);
                                SELECT LAST_INSERT_ID();";


            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@admissionNo", MySqlDbType.Int32) { Value = student.AdmissionNo },
            new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
            new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
            new MySqlParameter("@gender", MySqlDbType.Enum) { Value = student.Gender },
            new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = student.Phone ?? (object)DBNull.Value },
            new MySqlParameter("@email", MySqlDbType.VarChar) { Value = student.Email ?? (object)DBNull.Value },
            new MySqlParameter("@gradeid", MySqlDbType.Int32) { Value = student.GradeId },
            new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address ?? (object)DBNull.Value },
            new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
            new MySqlParameter("@enrollmentDate", MySqlDbType.Date) { Value = student.EnrollmentDate },
            new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = DateTime.Now },
            new MySqlParameter("@createdBy", MySqlDbType.Int32) { Value = student.CreatedBy }
            };


            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }


        public bool UpdateStudent(Model.Student student)
        {
            string query = @"UPDATE students SET
                         admission_no = @admissionNo,    
                         first_name = @firstName,
                         last_name = @lastName,
                         gender = @gender,
                         phone_no = @phone,  
                         email_id = @email, 
                         address = @address,
                         date_of_birth = @dob,
                         date_of_enrollment = @enrollmentDate,
                         updated_by = @updatedBy
                         WHERE id = @studentId";


            var parameters = new MySqlParameter[]
            {
                 new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = student.StudentId },
                 new MySqlParameter("@admissionNo", MySqlDbType.Int32) { Value = student.AdmissionNo },
                 new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
                 new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
                 new MySqlParameter("@gender", MySqlDbType.Enum) { Value = student.Gender },
                 new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = student.Phone ?? (object)DBNull.Value },
                 new MySqlParameter("@email", MySqlDbType.VarChar) { Value = student.Email ?? (object)DBNull.Value },
                 new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address ?? (object)DBNull.Value },
                 new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
                 new MySqlParameter("@enrollmentDate", MySqlDbType.Date) { Value = student.EnrollmentDate },
                 new MySqlParameter("@updatedBy", MySqlDbType.Int32) { Value = student.UpdatedBy }
            };


            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool DeleteStudent(int studentId)
        {
            string query = "DELETE FROM students WHERE id = @studentId";
            var parameter = new MySqlParameter("@studentId", MySqlDbType.Int32)
            {
                Value = studentId
            };
            return DbHelper.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
