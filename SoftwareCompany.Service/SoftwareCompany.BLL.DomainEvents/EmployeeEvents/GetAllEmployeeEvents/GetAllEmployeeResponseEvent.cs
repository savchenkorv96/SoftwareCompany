using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents
{
    public class GetAllEmployeeResponseEvent
    {
        public IEnumerable<Employee> Employees { get; set; }

        public GetAllEmployeeResponseEvent(IEnumerable<Employee> employees)
        {
            Employees = employees;
        }
    }
}
