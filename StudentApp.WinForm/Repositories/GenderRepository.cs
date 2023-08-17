using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace StudentApp.WinForm.Repositories
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
            command.CommandText = "Select * from Genders";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var addedGender = new Gender();

                addedGender.Id = Convert.ToInt32(reader[0]);
                addedGender.Definition = Convert.ToString(reader[1]);


                genders.Add(addedGender);
            }
            reader.Close();
            connection.Close();


            return genders;
        }
    }
}
