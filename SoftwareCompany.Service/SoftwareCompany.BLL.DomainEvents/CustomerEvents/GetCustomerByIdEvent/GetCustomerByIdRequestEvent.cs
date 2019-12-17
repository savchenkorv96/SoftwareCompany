using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent
{
    public class GetCustomerByIdRequestEvent
    {
        public int Id { get; set; }

        public GetCustomerByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
