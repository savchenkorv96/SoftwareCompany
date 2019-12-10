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

    }
}
