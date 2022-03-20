using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department_Backend.Core.Models;
using Department_Backend.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Department_Backend.Persistence
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly APPDBContext context;
        public EmployeeRepository(APPDBContext context)
        {
            this.context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            context.Employees.Add(employee);
        }

        public void EditEmployee(Employee employee)
        {
            context.Employees.Update(employee);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await context.Employees.Where(s => s.EmployeeId == employeeId)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync();
        }

        public void DeleteEmployee(Employee employee)
        {
            context.Entry(employee).State = EntityState.Deleted;
        }

        public async Task<IList<Employee>> GetEmployees()
        {
            return await context.Employees.AsNoTracking()

                                            .ToListAsync();
        }


    }
}
