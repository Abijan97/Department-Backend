using Department_Backend.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Core
{
    public interface IEmployeeService
    {
        Task<Employee> CreateNewEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<IList<Employee>> GetEmployees();
    }
}
