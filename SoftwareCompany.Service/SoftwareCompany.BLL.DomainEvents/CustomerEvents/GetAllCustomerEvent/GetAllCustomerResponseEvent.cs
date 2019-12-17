using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent
{
    public class GetAllCustomerResponseEvent
    {
        public IEnumerable<Customer> Customers { get; set; }

        public GetAllCustomerResponseEvent(IEnumerable<Customer> customers)
        {
            Customers = customers;
        }
    }
}
