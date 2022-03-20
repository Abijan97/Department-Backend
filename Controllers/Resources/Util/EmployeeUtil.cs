using Department_Backend.Core.Models;
using MYNDi.VP.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Controllers.Resources.Util
{
    public class EmployeeUtil
    {
        ///---New Landload---
        public static Employee EmployeeInputJson(EmployeeInputJson employeeInputJson)
        {
            var employee = new Employee();

            employee.EmployeeId = employeeInputJson.EmployeeId;
            employee.EmployeeName = employeeInputJson.EmployeeName;
            employee.Department = employeeInputJson.Department;
            employee.DateOfJoining = employeeInputJson.DateOfJoining;
            employee.PhotoFileName = employeeInputJson.PhotoFileName;



            return employee;
        }

        public static EmployeeResultJson EmployeeResultJson(Employee employee)
        {
            var employeeResultJson = new EmployeeResultJson();

            employeeResultJson.EmployeeId = employee.EmployeeId;
            employeeResultJson.EmployeeName = employee.EmployeeName;
            employeeResultJson.Department = employee.Department;
            employeeResultJson.DateOfJoining = employee.DateOfJoining;
            employeeResultJson.PhotoFileName = employee.PhotoFileName;


            return employeeResultJson;
        }

        public static List<EmployeeResultJson> EmployeesResultJson(IEnumerable<Employee> employee)
        {
            var resultjson = employee.Select(EmployeeResultJson).ToList();

            return resultjson;
        }

        public static EmployeeResultJson GetEmployeeResultJson(Employee Employee)
        {
            var employeeResultJson = new EmployeeResultJson();

            employeeResultJson.EmployeeId = Employee.EmployeeId;
            employeeResultJson.EmployeeName = Employee.EmployeeName;
            employeeResultJson.PhotoFileName = Employee.PhotoFileName;
            employeeResultJson.DateOfJoining = Employee.DateOfJoining;

            return employeeResultJson;
        }
    }
}
