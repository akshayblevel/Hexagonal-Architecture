using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Employee.Domain;

namespace Employee.Application
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> Get(string TenantId, string UserId);
    }
}
