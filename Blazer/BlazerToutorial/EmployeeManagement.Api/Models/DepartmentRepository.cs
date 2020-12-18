using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Department> GetDepartment(int departmentId)
        {
            var result = await appDbContext.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
            return result;
         }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var result = await appDbContext.Departments.ToListAsync();
            return result;
        }
    }
}
