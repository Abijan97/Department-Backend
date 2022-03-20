using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Department_Backend.Core.Models;
using ECommerce_Backend.Persistence;
using MYNDi.VP.Persistence;

namespace MYNDi.VP.Core
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IUnitOfWork unitOfWork;
        public DepartmentService(
            IDepartmentRepository departmentRepository,
            IUnitOfWork unitOfWork
            )
        {
            this.unitOfWork = unitOfWork;
            this.departmentRepository = departmentRepository;
        }
        public async Task<Department> CreateNewDepartment(Department department)
        {
            this.departmentRepository.CreateDepartment(department);

            await this.unitOfWork.CompleteAsync();

            return department;
        }
         
        public async Task<Department> UpdateDepartment(Department department)
        {

            this.departmentRepository.EditDepartment(department);

            await this.unitOfWork.CompleteAsync();

            return department;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            var existingDepartment = await this.departmentRepository.GetDepartmentById(departmentId);

           
            return existingDepartment;
        }


        public async Task<Department> DeleteDepartment(int departmentId)
        {
          
            var departmentObj = await this.departmentRepository.GetDepartmentById(departmentId);

            this.departmentRepository.DeleteDepartment(departmentObj);

            await this.unitOfWork.CompleteAsync();

            return departmentObj;
        }

        public async Task<IList<Department>> GetDepartments()
        {
            return await this.departmentRepository.GetDepartments();
        }

      
    }
}