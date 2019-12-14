using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Customer> Customers => _context.Customers;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Customer data)
        {
            throw new NotImplementedException();
        }

        public void Create(Customer data)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
