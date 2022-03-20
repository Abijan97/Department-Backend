using Department_Backend.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MYNDi.VP.Core
{
    public interface IDepartmentService
    {
        Task<Department> CreateNewDepartment(Department department);
        Task<Department> UpdateDepartment(Department department);
        Task<Department> GetDepartment(int departmentId);
        Task<Department> DeleteDepartment(int departmentId);
        Task<IList<Department>> GetDepartments();

    }
}