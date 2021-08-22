using Employees.Bll.Contracts;
using Employees.Core.Dto;
using Employees.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Bll
{
    public class EmployeesBll : IEmployeesBll
    {
        private readonly IEmployeesDal _employeesDal;

        public EmployeesBll(IEmployeesDal employeesDal)
        {
            this._employeesDal = employeesDal;
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            IEnumerable<EmployeeDto> employees = await this._employeesDal.Get();
            return employees;
        }
    }
}
