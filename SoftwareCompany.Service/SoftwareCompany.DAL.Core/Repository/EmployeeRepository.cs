using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Employee> Employees => _context.Set<Employee>().Include(x => x.Account).Include(x=>x.Team).ToList();

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
            _context.Set<Employee>().Include(x => x.Account);
            _context.Set<Employee>().Include(x => x.Team);
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return Employees.First((data) => data.Id == id);
        }

        public bool Create(Employee data)
        {
            _context.Employees.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Employee data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee data)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByAccountId(int id)
        {
            return Employees.First((data) => data.Account.Id == id);
        }
    }
}
