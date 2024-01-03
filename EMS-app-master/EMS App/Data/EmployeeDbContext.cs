using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_App.Models;

namespace EMS_App.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_App.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EMS_App.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
