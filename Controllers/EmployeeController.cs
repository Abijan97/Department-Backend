using Department_Backend.Controllers.Resources;
using Department_Backend.Controllers.Resources.Util;
using Department_Backend.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MYNDi.VP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Controllers
{
  
    [ApiController]
    [Route("/api/Employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        
        [HttpPost("CreateNewEmployee")]
        public async Task<IActionResult> CreateNewEmployee([FromBody] EmployeeInputJson employeeInputJson)
        {
            var inputJson = EmployeeUtil.EmployeeInputJson(employeeInputJson);

            var employee = await this.employeeService.CreateNewEmployee(inputJson);

            var resultJson = EmployeeUtil.EmployeeResultJson(employee);

            return Ok(resultJson);
        }

     
        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeInputJson employeeInputJson)
        {
            var inputJson = EmployeeUtil.EmployeeInputJson(employeeInputJson);

            var employee = await this.employeeService.UpdateEmployee(inputJson);

            var resultJson = EmployeeUtil.EmployeeResultJson(employee);

            return Ok(resultJson);
        }

      
        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee(int employeeId)
        {
            var employee = await this.employeeService.GetEmployee(employeeId);

            var resultJson = EmployeeUtil.EmployeeResultJson(employee);

            return Ok(resultJson);
        }

       
        [HttpPost("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee([FromBody] EmployeeInputJson employeeInputJson)
        {
            var employee = await this.employeeService.DeleteEmployee(employeeInputJson.EmployeeId);

            var resultJson = EmployeeUtil.EmployeeResultJson(employee);

            return Ok(resultJson);
        }

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await this.employeeService.GetEmployees();

            var resultJson = EmployeeUtil.EmployeesResultJson(employees);

            return Ok(resultJson);
        }


    }
}
