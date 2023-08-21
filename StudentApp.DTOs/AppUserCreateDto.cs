using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DTOs
{
    public class AppUserCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
