using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IEmployeeRepository : IRepository
    {
        IEnumerable<Employee> Employees { get; }

        IEnumerable<Employee> GetEmployeeList();
        Customer GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
