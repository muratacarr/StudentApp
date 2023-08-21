using StudentApp.Business.Interfaces;
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
    public class GenderManager : IGenderService
    {
        private readonly IGenderRepository genderRepository;
        public GenderManager() {
            genderRepository = new DataServiceRegistration().GetGenderRepositoryInstance();
        }

        public List<GenderListDto> GetGenders()
        {
            var genderListDto = new List<GenderListDto>();
           var genders =  genderRepository.GetGenders();
            foreach (var gender in genders)
            {
                var genderDto = new GenderListDto();
                genderDto.Id = gender.Id;
                genderDto.Definition = gender.Definition;

                genderListDto.Add(genderDto);   
            }

            return genderListDto;
        }
    }
}
