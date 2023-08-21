using Microsoft.Extensions.DependencyInjection;
using StudentApp.Business.Interfaces;
using StudentApp.Business.Managers;
using StudentApp.Data.Interfaces;
using StudentApp.Data.Repositories;

namespace StudentApp.Business
{
    public class BusinessServiceRegistration
    {
        ServiceProvider serviceProvider;
        public BusinessServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderService, GenderManager>()
                .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderService GetGenderServiceInstance()
        {
            return serviceProvider.GetRequiredService<IGenderService>();
        }

        //public IIn GetInstructorRepositoryInstance()
        //{
        //    return serviceProvider.GetRequiredService<IInstructorRepository>();
        //}
    }
}
