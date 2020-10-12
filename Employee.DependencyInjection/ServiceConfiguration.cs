using Microsoft.Extensions.DependencyInjection;
using Employee.Application;
using Employee.Domain;
using Employee.Infrastructure;

namespace Employee.DependencyInjection
{
    public static class ServicesConfiguration
    {
        public static void AddEmployeeServices(this IServiceCollection services)
        {
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IEmployeeReadOnlyRepository, EmployeeRepository>();
            services.AddSingleton<IEmployeeWriteOnlyRepository, EmployeeRepository>();
        }
    }
}
