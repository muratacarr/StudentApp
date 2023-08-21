using StudentApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business.Interfaces
{
    public interface IAppUserService
    {
        void CreateUser(AppUserCreateDto createdDto);
    }
}
