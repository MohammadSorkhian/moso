using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(new Employee
                {
                    EmployeeId = 1,
                    FirstName = "firstname_1",
                    LastName = "lastname_1",
                    Email = "email_1",
                    DateOfBirth = new DateTime(2020, 01, 01),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "image/1.jpg"
                });
            modelBuilder.Entity<Employee>().HasData(new Employee
                {
                    EmployeeId = 2,
                    FirstName = "firstname_2",
                    LastName = "lastname_2",
                    Email = "email_2",
                    DateOfBirth = new DateTime(2020, 02, 02),
                    Gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "image/2.jpg"
                });
            modelBuilder.Entity<Employee>().HasData(new Employee
                {
                    EmployeeId = 3,
                    FirstName = "firstname_3",
                    LastName = "lastname_3",
                    Email = "email_3",
                    DateOfBirth = new DateTime(2020, 03, 03),
                    Gender = Gender.Male,
                    DepartmentId = 3,
                    PhotoPath = "image/3.jpg"
                });
            modelBuilder.Entity<Employee>().HasData(new Employee
                {
                    EmployeeId = 4,
                    FirstName = "firstname_4",
                    LastName = "lastname_4",
                    Email = "email_4",
                    DateOfBirth = new DateTime(2020, 04, 04),
                    Gender = Gender.Male,
                    DepartmentId = 4,
                    PhotoPath = "image/4.jpg"
                });

        }
    }
}
