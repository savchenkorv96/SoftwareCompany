using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents
{
    public class CreateAccountResponseEvent
    {
        public Account Account { get; set; }

        public CreateAccountResponseEvent(Account account)
        {
            this.Account = account;
        }
    }
}
