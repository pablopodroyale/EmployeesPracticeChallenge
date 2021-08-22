using Employees.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Bll.Contracts
{
    public interface IEmployeesBll
    {
        Task<IEnumerable<EmployeeDto>> Get();
    }
}
