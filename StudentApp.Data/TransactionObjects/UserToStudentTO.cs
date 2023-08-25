using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.TransactionObjects
{
    public class UserToStudentTO
    {
        public int CreatedUserId { get; set; }
        public SqlTransaction Transaction { get; set; }
        public SqlConnection SqlConnection { get; set; }
    }
}
