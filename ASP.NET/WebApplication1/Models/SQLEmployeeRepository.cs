using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }


        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }


        public Employee Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null) 
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }


        public IEnumerable<Employee> GetAllEmployee()
        {
            throw new NotImplementedException();
        }


        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }


        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
