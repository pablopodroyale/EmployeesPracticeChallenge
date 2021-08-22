using Employees.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Dal.Contracts
{
    public interface IEmployeesDal
    {
        Task<IEnumerable<EmployeeDto>> Get();
    }
}
