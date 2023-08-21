using StudentApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business.Interfaces
{
    public interface IGenderService
    {
        List<GenderListDto> GetGenders();
    }
}
