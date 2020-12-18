using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee) 
        {
            var result =  await appdbContext.Employees.AddAsync(employee);
            await appdbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async void DeleteEmployee(int employeeId)
        {
            var result = await appdbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (result != null)
            {
                appdbContext.Remove(result);
                await appdbContext.SaveChangesAsync();
            }
            throw new NotImplementedException();
        }
        public async Task<Employee> GetEmployee(int employeeId)
        {
            var result = await appdbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            return result;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var result = await appdbContext.Employees.ToListAsync();
            return result;
        }
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appdbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appdbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
