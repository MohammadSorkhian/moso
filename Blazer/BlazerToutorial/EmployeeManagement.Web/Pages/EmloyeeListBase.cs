using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Pages
{
    public class EmloyeeListBase: ComponentBase
    {
        public IEnumerable <Employee> Employees { get; set; }

        //protected override Task OnInitializedAsync()
        //{
        //    LoadEmployees();
        //    return base.OnInitializedAsync();
        //}

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(2000);

            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "f1",
                LastName = "l1",
                Email = "email1",
                DateOfBirth = new DateTime(2020,1,1),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/1.jpg"
            };

            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "f2",
                LastName = "l2",
                Email = "email2",
                DateOfBirth = new DateTime(2020, 1, 2),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/2.jpg"

            }; 
            
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "f3",
                LastName = "l3",
                Email = "email3",
                DateOfBirth = new DateTime(2020, 1, 3),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/3.jpg"

            }; 
            
            Employee e4 = new Employee()
            {
                EmployeeId = 4,
                FirstName = "f4",
                LastName = "l4",
                Email = "email4",
                DateOfBirth = new DateTime(2020, 1, 4),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "images/4.jpg"
            };
            
            Employees = new List<Employee> { e1, e2, e3, e4 };
            
        }



    }
}
