using Microsoft.Extensions.DependencyInjection;
using StudentApp.Data.Interfaces;
using StudentApp.Data.Repositories;
using System;

namespace StudentApp.Data
{
    public class DataServiceRegistration
    {

        ServiceProvider serviceProvider;
        public DataServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>()
                .AddScoped<IInstructorRepository, InstructorRepository>().AddScoped<IAppUserRepository, AppUserRepository>().AddScoped<IStudentRepository, StudentRepository>().BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderRepository GetGenderRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IGenderRepository>();
        }

        public IInstructorRepository GetInstructorRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IInstructorRepository>();
        }

        public IAppUserRepository GetAppUserRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IAppUserRepository>();
        }

        public IStudentRepository GetStudentRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IStudentRepository>();
        }

    }
}