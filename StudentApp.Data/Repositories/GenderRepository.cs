using StudentApp.Data.Helpers;
using StudentApp.Data.Interfaces;
using StudentApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        public List<Gender> GetGenders()
        {

            var connection = new DbConnectionHelper().Connection;

            List<Gender> genders = new List<Gender>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Genders";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var gender = new Gender();
                gender.Id = reader.GetInt32(0);
                gender.Definition=reader.GetString(1);
                
                genders.Add(gender);
            }
            reader.Close();
            connection.Close();


            return genders;
        }
    }
}
