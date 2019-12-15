using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents
{
    public class GetAccountByIdResponseEvent
    {
        public Account Account { get; set; }

        public GetAccountByIdResponseEvent(Account account)
        {
            Account = account;
        }
    }
}
