using StudentApp.WinForm.Entities;
using StudentApp.WinForm.Helpers;
using StudentApp.WinForm.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace StudentApp.WinForm.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        public List<Instructor> GetInstructors()
        {
            // DTO => Business



            var connection = new DbConnectionHelper().Connection;

            List<Instructor> instructors = new List<Instructor>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Users 
inner join Instructors
on Users.Id = Instructors.UserId";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var instructor = new Instructor();

                instructor.Id = Convert.ToInt32(reader[0]);
                instructor.Name = Convert.ToString(reader[1]);
                instructor.Surname = Convert.ToString(reader[2]);
                instructor.GenderId = Convert.ToInt32(reader[3]);
                instructor.PhoneNumber = Convert.ToString(reader[4]);
                instructor.Username = Convert.ToString(reader[5]);
                instructor.Password = Convert.ToString(reader[6]);
                instructor.Salary = Convert.ToInt32(reader[8]);
                instructor.UserId = Convert.ToInt32(reader[9]);


                instructors.Add(instructor);
            }
            reader.Close();
            connection.Close();


            return instructors;

        }
    }
}
