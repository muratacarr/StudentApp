using Microsoft.Extensions.DependencyInjection;
using StudentApp.WinForm.Interfaces;
using StudentApp.WinForm.Repositories;

namespace StudentApp.WinForm.Container
{
    public class DependencyContainer
    {
        //Dependency Inversion... 


        ServiceProvider serviceProvider;
        public DependencyContainer()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>()
                .AddScoped<IInstructorRepository, InstructorRepository>().BuildServiceProvider();
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
    }
}
