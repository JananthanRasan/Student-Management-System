﻿using MySql.Data.MySqlClient;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class SubjectDal
    {
        public DataTable GetAllSubjects()
        {
            string query = @"SELECT id, subject_name, subject_index, subject_order,
                        subject_color
                        FROM subjects ORDER BY subject_order";

            return DbHelper.GetData(query);
        }


        public Subject GetSubjectById(int subjectId)
        {
            string query = @"SELECT * FROM subjects WHERE id = @subjectId";

            var parameter = new MySqlParameter("@subjectId", MySqlDbType.Int32)
            {
                Value = subjectId
            };


            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;


            DataRow row = dt.Rows[0];
            return new Model.Subject
            {
                SubjectId = Convert.ToInt32(row["id"]),
                SubjectName = row["subject_name"].ToString(),
                SubjectIndex = row["subject_index"].ToString(),
                SubjectOrder = Convert.ToDouble(row["subject_order"]),
                SubjectColor = row["subject_color"].ToString()

            };
        }


        public int AddSubject(Subject subject)
        {
            string query = @"INSERT INTO subjects
                                (subject_name, subject_index, subject_order, subject_color, created_at, created_by)
                                VALUES (@subjectName, @subjectIndex, @subjectOrder,@subjectColor, @createdAt, @createdBy);
                                SELECT LAST_INSERT_ID();";


            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@subjectName", MySqlDbType.VarChar) { Value = subject.SubjectName },
            new MySqlParameter("@subjectIndex", MySqlDbType.VarChar) { Value = subject.SubjectIndex },
            new MySqlParameter("@subjectColor", MySqlDbType.VarChar) { Value = subject.SubjectColor },
            new MySqlParameter("@subjectOrder", MySqlDbType.Double) { Value = subject.SubjectOrder },
            new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = DateTime.Now },
            new MySqlParameter("@createdBy", MySqlDbType.Int32) { Value = subject.CreatedBy }
            };


            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }


        public bool UpdateSubject(Subject subject)
        {
            string query = @"UPDATE subjects SET
                         subject_name = @subjectName, 
                         subject_index = @subjectIndex, 
                         subject_order = @subjectOrder,
                         subject_color = @subjectColor,
                         updated_by = @updatedBy
                         WHERE id = @subjectId";


            var parameters = new MySqlParameter[]
            {
                 new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = subject.SubjectId },
                 new MySqlParameter("@subjectName", MySqlDbType.VarChar) { Value = subject.SubjectName },
                 new MySqlParameter("@subjectIndex", MySqlDbType.VarChar) { Value = subject.SubjectIndex },
                 new MySqlParameter("@subjectColor", MySqlDbType.VarChar) { Value = subject.SubjectColor },
                 new MySqlParameter("@subjectOrder", MySqlDbType.Double) { Value = subject.SubjectOrder },
                 new MySqlParameter("@updatedBy", MySqlDbType.Int32) { Value = subject.UpdatedBy }
            };


            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool DeleteSubject(int subjectId)
        {
            string query = "DELETE FROM subjects WHERE id = @subjectId";
            var parameter = new MySqlParameter("@subjectId", MySqlDbType.Int32)
            {
                Value = subjectId
            };
            return DbHelper.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
