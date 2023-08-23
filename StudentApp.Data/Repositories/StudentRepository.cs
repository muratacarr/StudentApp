using StudentApp.Data.Helpers;
using StudentApp.Data.Interfaces;
using StudentApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student student)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Students values(@studentNumber,@instructorId,@userId)";

            command.Parameters.AddWithValue("@studentNumber", student.StudentNumber);
            command.Parameters.AddWithValue("@instructorId", student.InstructorId);
            command.Parameters.AddWithValue("@userId", student.UserId);


            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
    }
}
