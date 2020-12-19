﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        Task<Employee> GetEmployee(int employeeId);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> UpdateEmployee(Employee employee);
    }
}
