using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department_Backend.Core.Models;
using Department_Backend.Persistence;
using ECommerce_Backend.Persistence;
using Microsoft.EntityFrameworkCore;


namespace MYNDi.VP.Persistence
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly APPDBContext context;
        public DepartmentRepository(APPDBContext context)
        {
            this.context = context;
        }
        public DepartmentRepository() { }

        public void CreateDepartment(Department department)
        {
            context.Departments.Add(department);
        }

        public void EditDepartment(Department department)
        {
            context.Departments.Update(department);
        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await context.Departments.Where(s => s.DepartmentId == departmentId)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync();
        }

        public void DeleteDepartment(Department department)
        {
            context.Entry(department).State = EntityState.Deleted;
        }

        public async Task<IList<Department>> GetDepartments()
        {
            return await context.Departments.AsNoTracking()

                                            .ToListAsync();
        }




    }
}