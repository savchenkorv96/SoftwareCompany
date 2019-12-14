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
