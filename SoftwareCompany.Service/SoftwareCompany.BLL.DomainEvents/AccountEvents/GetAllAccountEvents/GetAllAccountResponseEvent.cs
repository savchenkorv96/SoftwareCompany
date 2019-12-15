using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents
{
    public class GetAllAccountResponseEvent
    {
        public IEnumerable<Account> ListAccounts { get; set; }

        public GetAllAccountResponseEvent(IEnumerable<Account> listAccounts)
        {
            ListAccounts = listAccounts;
        }
    }
}
