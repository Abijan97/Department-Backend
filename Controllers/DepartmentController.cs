using Department_Backend.Controllers.Resources;
using Department_Backend.Controllers.Resources.Util;
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
    [Route("/api/Departments")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

      
        [HttpPost("CreateNewDepartment")]
        public async Task<IActionResult> CreateNewDepartment([FromBody] DepartmentInputJson departmentInputJson)
        {
            var inputJson = DepartmentUtil.DepartmentInputJson(departmentInputJson);

            var department = await this.departmentService.CreateNewDepartment(inputJson);

            var resultJson = DepartmentUtil.DepartmentResultJson(department);

            return Ok(resultJson);
        }

      
        [HttpPost("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentInputJson departmentInputJson)
        {
            var inputJson = DepartmentUtil.DepartmentInputJson(departmentInputJson);

            var department = await this.departmentService.UpdateDepartment(inputJson);

            var resultJson = DepartmentUtil.DepartmentResultJson(department);

            return Ok(resultJson);
        }

      
        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment(int departmentId)
        {
            var department = await this.departmentService.GetDepartment(departmentId);

            var resultJson = DepartmentUtil.DepartmentResultJson(department);

            return Ok(resultJson);
        }

       
        [HttpPost("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment([FromBody] DepartmentInputJson departmentInputJson)
        {

            var departmentt = await this.departmentService.DeleteDepartment(departmentInputJson.DepartmentId);

            var resultJson = DepartmentUtil.DepartmentResultJson(departmentt);

            return Ok(resultJson);
        }
         
       
        [HttpGet("GetDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await this.departmentService.GetDepartments();

            var resultJson = DepartmentUtil.DepartmentsResultJson(departments);

            return Ok(resultJson);
        }

  
    } 
}
