using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents
{
    public class CreateAccountRequestEvent
    {
        public Account Account { get; set; }

        public CreateAccountRequestEvent(Account account)
        {
            this.Account = account;
        }
    }
}
