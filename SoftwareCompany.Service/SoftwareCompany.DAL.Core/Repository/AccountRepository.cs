using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Account> Accounts => _context.Accounts;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
