using System;
using System.Collections.Generic;
using System.Linq;
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

        public Account GetAccountByLoginAndPassword(string login, string password)
        {
            return Accounts.First((data) => data.Login == login && data.Password == password);
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            return Accounts.First((data) => data.Id == id);
        }

        public bool Create(Account data)
        {
            _context.Accounts.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Account data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Account data)
        {
            throw new NotImplementedException();
        }
    }
}
