using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain
{
    public interface IEmployeeWriteOnlyRepository
    {
        Task Add(EmployeeDTO Employee);
    }
}
