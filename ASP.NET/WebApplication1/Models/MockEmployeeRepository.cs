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
                new Employee() { Id = 1, Name = "Mary", Department = Department.HR, Email = "Mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = Department.IT, Email = "John@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Department.IT, Email = "Sam@gmail.com" },
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeelist.Max(e => e.Id) + 1;
            _employeelist.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee emp = _employeelist.FirstOrDefault(emp => emp.Id == id);
            if (emp != null)
            {
                _employeelist.Remove(emp);
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeelist;
        }

        public Employee GetEmployee(int id)
        {
            return _employeelist.FirstOrDefault(Emp => Emp.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee emp = _employeelist.FirstOrDefault(emp => emp == employeeChanges);
            if (emp != null)
            {
                emp.Name = employeeChanges.Name;
                emp.Department = employeeChanges.Department;
                emp.Email = employeeChanges.Email;
            }
            return emp;
        }

    }
}
