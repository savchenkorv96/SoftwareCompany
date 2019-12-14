using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Employee> Employees => _context.Employees;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(Employee data)
        {
            throw new NotImplementedException();
        }

        public void Create(Employee data)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee data)
        {
            throw new NotImplementedException();
        }
    }
}
