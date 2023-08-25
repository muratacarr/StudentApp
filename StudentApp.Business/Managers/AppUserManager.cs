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
        private readonly IStudentRepository studentRepository;

        // => PAYMENT MANAGER => o kadar yoğun  
        // => AppUserManager  => ActiveUser => sadece 1 kere çağrılıyor.

        // N KATMANLI MİMARI 
        // ONION MİMARI 
        // MINIMAL API 


        // MICROSERVİCE => Bir mimari mi ? 



        // HASTA => HASTALIK => TEDAVI

        // Her hastalık tedavi edilir mi ?

        public AppUserManager()
        {
            var container = new DataServiceRegistration();

            userRepository = container.GetAppUserRepositoryInstance();
            studentRepository = container.GetStudentRepositoryInstance();
        }
        public string CreateUser(StudentCreateDto createdDto)
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


            // bundan nasıl kaçınabiliriz ??? 

            // Scaling
            // TRANSACTION MANAGEMENT
            // ADO.NET TRANSACTION => 

            // bir iş  transaction 
            var userToStudentTO = userRepository.Create(new Entities.AppUser
            {
                GenderId = createdDto.GenderId,
                Name = createdDto.Name,
                Password = HashHelper.HashString(createdDto.Password),
                PhoneNumber = createdDto.PhoneNumber,
                Surname = createdDto.Surname,
                Username = createdDto.Username,
            });


            // bir iş transaction
            string result = studentRepository.Create(new Entities.Student
            {
                InstructorId = createdDto.InstructorId,
                StudentNumber = createdDto.StudentNumber,
                UserId = userToStudentTO.CreatedUserId,
            }, userToStudentTO);

            return result;

        }
    }
}




