using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeelist;
        public MockEmployeeRepository()
        {
            _employeelist = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "Mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = "IT", Email = "John@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "Sam@gmail.com" },
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeelist.FirstOrDefault(Emp => Emp.Id == id);
        }
    }
}
