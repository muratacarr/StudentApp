using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Entities
{
    public class Instructor : AppUser
    {
        public int Salary { get; set; }

        public int UserId { get; set; }
    }
}
