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

        public IEnumerable<Account> GetAccountList()
        {
            return Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return Accounts.First((data) => data.Id == id);
        }

        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            var oldAccount = GetAccountById(account.Id);
            oldAccount = account;
            _context.SaveChanges();
        }

        public void DeleteAccount(Account account)
        {
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }
    }
}
