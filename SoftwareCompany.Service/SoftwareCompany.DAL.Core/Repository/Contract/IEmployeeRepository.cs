using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> Employees { get; }

    }
}
