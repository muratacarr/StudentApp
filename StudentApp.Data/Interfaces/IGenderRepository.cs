using StudentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.Interfaces
{
    public interface IGenderRepository
    {
            List<Gender> GetGenders();
    }
}
