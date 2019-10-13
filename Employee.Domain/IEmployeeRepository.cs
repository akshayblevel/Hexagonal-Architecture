using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Domain
{
    public interface IEmployeeRepository : IEmployeeReadOnlyRepository, IEmployeeWriteOnlyRepository
    {
    }
}
