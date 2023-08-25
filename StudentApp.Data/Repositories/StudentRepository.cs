using StudentApp.Data.Helpers;
using StudentApp.Data.Interfaces;
using StudentApp.Data.TransactionObjects;
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
        public string Create(Student student, UserToStudentTO userToStudentTO)
        {
            var connection = userToStudentTO.SqlConnection;
            SqlTransaction sqlTransaction = userToStudentTO.Transaction;
            try
            {
                //var connection = new DbConnectionHelper().Connection;
                var command = new SqlCommand("insert into Students values(@studentNumber,@instructorId,@userId)", connection, sqlTransaction);

                //command.Connection = connection;
                //command.CommandType = System.Data.CommandType.Text;
                //command.CommandText = "insert into Students values(@studentNumber,@instructorId,@userId)";


                command.Parameters.AddWithValue("@studentNumber", student.StudentNumber);
                command.Parameters.AddWithValue("@instructorId", student.InstructorId);
                command.Parameters.AddWithValue("@userId", student.UserId);


                //connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                sqlTransaction.Commit();
                connection.Close();
                return "Kayıt Başarılı Bir Şekilde Yapılmıştır";
            }
            catch (Exception)
            {
                sqlTransaction.Rollback();
                connection.Close();
                return "Kayıt Yapılamamıştır";
            }

        }
    }
}
