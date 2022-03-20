using Department_Backend.Persistence;
using MYNDi.VP.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Core.Models
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;
        public EmployeeService(
            IEmployeeRepository employeeRepository,
            IUnitOfWork unitOfWork
            )
        {
            this.unitOfWork = unitOfWork;
            this.employeeRepository = employeeRepository;
        }
        public async Task<Employee> CreateNewEmployee(Employee employee)
        {
            this.employeeRepository.CreateEmployee(employee);

            await this.unitOfWork.CompleteAsync();

            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {

            this.employeeRepository.EditEmployee(employee);

            await this.unitOfWork.CompleteAsync();

            return employee;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            var existingEmployee = await this.employeeRepository.GetEmployeeById(employeeId);


            return existingEmployee;
        }


        public async Task<Employee> DeleteEmployee(int employeeId)
        {

            var employeeObj = await this.employeeRepository.GetEmployeeById(employeeId);

            this.employeeRepository.DeleteEmployee(employeeObj);

            await this.unitOfWork.CompleteAsync();

            return employeeObj;
        }

        public async Task<IList<Employee>> GetEmployees()
        {
            return await this.employeeRepository.GetEmployees();
        }

    }
}
