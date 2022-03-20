using Department_Backend.Core.Models;
using MYNDi.VP.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Department_Backend.Controllers.Resources.Util
{
    public class DepartmentUtil
    {
        ///---New Landload---
        public static Department DepartmentInputJson(DepartmentInputJson departmentInputJson)
        {
            var department = new Department();

            department.DepartmentId = departmentInputJson.DepartmentId;
            department.DepartmentName = departmentInputJson.DepartmentName;



            return department;
        }

        public static DepartmentResultJson DepartmentResultJson(Department department)
        {
            var departmentResultJson = new DepartmentResultJson();

            departmentResultJson.DepartmentId = department.DepartmentId;
            departmentResultJson.DepartmentName = department.DepartmentName;


            return departmentResultJson;
        }

        public static List<DepartmentResultJson> DepartmentsResultJson(IEnumerable<Department> department)
        {
            var resultjson = department.Select(DepartmentResultJson).ToList();

            return resultjson;
        }

        public static ListResultJson GetDepartmentResultJson(Department Department)
        {
            var departmentResultJson = new ListResultJson();

            departmentResultJson.Id = Department.DepartmentId;
            departmentResultJson.Name = Department.DepartmentName;

            return departmentResultJson;
        }
    }
}