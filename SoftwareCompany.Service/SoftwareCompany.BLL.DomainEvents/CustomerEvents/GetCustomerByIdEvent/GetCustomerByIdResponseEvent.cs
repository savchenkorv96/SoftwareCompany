using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent
{
    public class GetCustomerByIdResponseEvent
    {
        public Customer Customer { get; set; }

        public GetCustomerByIdResponseEvent(Customer customer)
        {
            Customer = customer;
        }
    }
}
