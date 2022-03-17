using Department_Backend.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_Backend.Persistence
{
    public class APPDBContext:DbContext
    {
        public APPDBContext(DbContextOptions<APPDBContext> options)
       : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
    }
}
