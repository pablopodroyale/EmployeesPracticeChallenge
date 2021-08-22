using Employees.Core.Dto;
using Employees.Core.Model;
using Employees.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Dal
{
    public class EmployeesDal : IEmployeesDal
    {
        private readonly HttpClient _client;

        public EmployeesDal(HttpClient client)
        {
            this._client = client;
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            List<EmployeeDto> result = new List<EmployeeDto>();
            _client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net/api/");
            var responseTask = await _client.GetAsync("Employees");
            if (responseTask.IsSuccessStatusCode)
            {
                var readTask = responseTask.Content.ReadAsAsync<Employee[]>();
                readTask.Wait();
                var employees = readTask.Result;
                EmployeeDto employeeDto = null;
                foreach (var employee in employees)
                {
                    employeeDto = new EmployeeDto
                    {
                        Id = employee.id,
                        Name = employee.contractTypeName,
                        RoleId = employee.roleId,
                        RoleName = employee.roleName,
                        RoleDescription = employee.roleDescription,
                        HourlySalary = employee.hourlySalary,
                        MonthlySalary = employee.monthlySalary,
                        ContractTypeName = employee.contractTypeName
                    };

                    result.Add(employeeDto);
                }
            }

            return result;
        }
    }
}
