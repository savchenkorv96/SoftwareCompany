using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents
{
    public class GetEmployeeByAccountIdResponseEvent
    {
        public Employee Employee { get; set; }

        public GetEmployeeByAccountIdResponseEvent(Employee employee)
        {
            Employee = employee;
        }
    }
}
