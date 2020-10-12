using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Employee.Domain;

namespace Employee.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task Add(EmployeeDTO Employee)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDTO> Get(string TenantId, string UserId)
        {
            return new EmployeeDTO() { EmployeeId = 5677 };
        }
    }
}
