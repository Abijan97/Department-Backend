using Department_Backend.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Persistence
{
    public interface IEmployeeRepository
    {
       void CreateEmployee(Employee employee);
       void EditEmployee(Employee employee);
       Task<Employee> GetEmployeeById(int employeeId);
       void DeleteEmployee(Employee employee);
       Task<IList<Employee>> GetEmployees();
    }
}
