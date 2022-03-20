using Department_Backend.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECommerce_Backend.Persistence
{
    public interface IDepartmentRepository
    {
        void CreateDepartment(Department department);
        void EditDepartment(Department department);
        Task<Department> GetDepartmentById(int departmentId);
        void DeleteDepartment(Department department);
        Task<IList<Department>> GetDepartments();
    }
}
