using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents
{
    public class CreateAccountResponseEvent
    {
        public bool Status { get; set; }

        public CreateAccountResponseEvent(bool status)
        {
            this.Status = status;
        }
    }
}
