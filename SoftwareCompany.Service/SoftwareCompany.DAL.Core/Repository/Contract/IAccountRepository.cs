using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IAccountRepository : IRepository
    {
        IEnumerable<Account> Accounts { get; }

        Account GetAccountByLoginAndPassword(string login, string password);
        IEnumerable<Account> GetAccountList();
        Account GetAccountById(int id);
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);
    }
}
