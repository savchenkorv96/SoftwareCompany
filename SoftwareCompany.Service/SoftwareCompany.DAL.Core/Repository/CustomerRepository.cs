using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Customer> Customers => _context.Set<Customer>().Include(x => x.Account).Include(x=>x.Company);

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return Customers.First(data => data.Id == id);
        }

        public bool Create(Customer data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
