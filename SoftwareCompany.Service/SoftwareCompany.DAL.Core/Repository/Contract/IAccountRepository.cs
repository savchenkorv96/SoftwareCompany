using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IAccountRepository : IRepository<Account>
    {
        IEnumerable<Account> Accounts { get; }

        Account GetAccountByLoginAndPassword(string login, string password);
        
    }
}
