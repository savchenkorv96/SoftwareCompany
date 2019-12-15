using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents
{
    public class GetEmployeeByIdResponseEvent
    {
        public Employee Employee { get; set; }

        public GetEmployeeByIdResponseEvent(Employee employee)
        {
            Employee = employee;
        }
    }
}
