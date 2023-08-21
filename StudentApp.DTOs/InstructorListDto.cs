using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DTOs
{
    public class InstructorListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Salary { get; set; }

        public int UserId { get; set; }
    }
}
