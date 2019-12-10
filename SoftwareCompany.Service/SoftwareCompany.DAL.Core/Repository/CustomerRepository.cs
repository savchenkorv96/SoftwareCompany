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

    }
}
