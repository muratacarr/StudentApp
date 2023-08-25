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
    public class AppUserRepository : IAppUserRepository
    {
        public UserToStudentTO Create(AppUser appUser)
        {
            var connection = new DbConnectionHelper().Connection;
            connection.Open();
            SqlTransaction sqlTransaction = connection.BeginTransaction();
            try
            {
                var command = new SqlCommand("insert into Users OUTPUT INSERTED.Id values(@name,@surname,@genderId,@phoneNumber,@username,@password)", connection, sqlTransaction);
                //command.Connection = connection;
                //command.CommandType = System.Data.CommandType.Text;
                //command.CommandText = "insert into Users OUTPUT INSERTED.Id values(@name,@surname,@genderId,@phoneNumber,@username,@password)";

                command.Parameters.AddWithValue("@name", appUser.Name);
                command.Parameters.AddWithValue("@surname", appUser.Surname);
                command.Parameters.AddWithValue("@genderId", appUser.GenderId);
                command.Parameters.AddWithValue("@phoneNumber", appUser.PhoneNumber);
                command.Parameters.AddWithValue("@username", appUser.Username);
                command.Parameters.AddWithValue("@password", appUser.Password);


                var returnValue = command.ExecuteScalar();
                int rv = Convert.ToInt32(returnValue);
                command.Parameters.Clear();

                return new UserToStudentTO
                {
                    CreatedUserId = rv,
                    SqlConnection = connection,
                    Transaction = sqlTransaction
                };
            }
            catch (SqlException)
            {
                sqlTransaction.Rollback();
                connection.Close();
                throw;
            }

            //connection.Close();
        }
    }
}
