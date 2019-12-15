using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents
{
    public class CreateEmployeeRequestEvent
    {
        public Employee Employee { get; set; }

        public CreateEmployeeRequestEvent(Employee employee)
        {
            Employee = employee;
        }
    }
}
