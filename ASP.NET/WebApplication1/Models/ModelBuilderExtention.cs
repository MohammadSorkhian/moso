using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public static class ModelBuilderExtention
    {
        //MoSo: Instead of building this class we can explicitly add modelBuilder.Entity ... to the AppDbContext.cs 
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mary",
                    Department = Department.IT,
                    Email = "Mary@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Department.HR,
                    Email = "John@gmail.com"
                }
                );
        }
    }
}
