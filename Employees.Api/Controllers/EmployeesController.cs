using Employees.Bll.Contracts;
using Employees.Core.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesBll _employeesBll;
        public EmployeesController(IEmployeesBll employeesBll)
        {
            this._employeesBll = employeesBll;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            IEnumerable<EmployeeDto> result = await _employeesBll.Get();
            return result;
        }
    }
}