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
            serviceProvider = new ServiceCollection().AddScoped<IGenderService, GenderManager>().AddScoped<IInstructorService, InstructorManager>().AddScoped<IAppUserService, AppUserManager>()
                .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderService GetGenderServiceInstance()
        {
            return serviceProvider.GetRequiredService<IGenderService>();
        }

        public IInstructorService GetInstructorServiceInstance()
        {
            return serviceProvider.GetRequiredService<IInstructorService>();
        }

        public IAppUserService GetAppUserServiceInstance()
        {
            return serviceProvider.GetRequiredService<IAppUserService>();
        }
    }
}
