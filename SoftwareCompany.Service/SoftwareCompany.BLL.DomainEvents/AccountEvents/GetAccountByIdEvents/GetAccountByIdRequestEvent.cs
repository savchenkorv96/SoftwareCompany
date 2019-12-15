using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents
{
    public class GetAccountByIdRequestEvent
    {
        public int Id { get; set; }

        public GetAccountByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
