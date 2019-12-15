using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents
{
    public class CreateEmployeeResponseEvent 
    {
        public bool Status { get; set; }

        public CreateEmployeeResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
