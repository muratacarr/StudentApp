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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository instructorRepository;
        public InstructorManager()
        {
            instructorRepository = new DataServiceRegistration().GetInstructorRepositoryInstance();
        }
        public List<InstructorSelectListDto> GetInstructors()
        {
            var dtoList = new List<InstructorSelectListDto>();

            var list = instructorRepository.GetInstructors();
            foreach (var instructor in list)
            {
                var dto = new InstructorSelectListDto();

                dto.Id = instructor.Id;
                dto.FullName = instructor.Name + " " + instructor.Surname;
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
