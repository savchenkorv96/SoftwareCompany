﻿using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> Customers { get; }

    }
}
