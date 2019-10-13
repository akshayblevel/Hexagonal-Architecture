using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Employee.Domain;

namespace Employee.Application
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeReadOnlyRepository EmployeeReadOnlyRepository;
        private readonly IEmployeeWriteOnlyRepository EmployeeWriteOnlyRepository;
        public EmployeeService(IEmployeeReadOnlyRepository EmployeeReadOnlyRepository, IEmployeeWriteOnlyRepository EmployeeWriteOnlyRepository)
        {
            this.EmployeeReadOnlyRepository = EmployeeReadOnlyRepository;
            this.EmployeeWriteOnlyRepository = EmployeeWriteOnlyRepository;
        }
        public async Task<EmployeeDTO> Get(string TenantId, string UserId)
        {
            return await EmployeeReadOnlyRepository.Get(TenantId, UserId);
        }
    }
}
