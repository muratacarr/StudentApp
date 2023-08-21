using StudentApp.Business.Interfaces;
using StudentApp.Business.Tools;
using StudentApp.Data;
using StudentApp.Data.Interfaces;
using StudentApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business.Managers
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository userRepository;
        public AppUserManager()
        {
            userRepository = new DataServiceRegistration().GetAppUserRepositoryInstance();
        }
        public void CreateUser(AppUserCreateDto createdDto)
        {
            //var user = new Entities.AppUser { 
            //GenderId = createdDto.GenderId,
            //Name = createdDto.Name,
            //Password = createdDto.Password,
            //PhoneNumber = createdDto.PhoneNumber,
            //Surname = createdDto.Surname,
            //Username= createdDto.Username,
            //};
            //userRepository.Create(user);


            userRepository.Create(new Entities.AppUser
            {
                GenderId = createdDto.GenderId,
                Name = createdDto.Name,
                Password = HashHelper.HashString(createdDto.Password),
                PhoneNumber = createdDto.PhoneNumber,
                Surname = createdDto.Surname,
                Username = createdDto.Username,
            });
        }
    }
}
