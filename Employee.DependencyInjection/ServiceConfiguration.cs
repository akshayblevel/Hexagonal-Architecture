using Microsoft.Extensions.DependencyInjection;
using Employee.Application;

namespace Employee.DependencyInjection
{
    public static class ServicesConfiguration
    {
        public static void AddEmployeeServices(this IServiceCollection services)
        {
            services.AddSingleton<IEmployeeService, EmployeeService>();
        }
    }
}
