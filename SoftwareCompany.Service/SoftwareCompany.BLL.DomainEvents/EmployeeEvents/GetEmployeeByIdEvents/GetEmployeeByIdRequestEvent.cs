using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents
{
    public class GetEmployeeByIdRequestEvent
    {
        public int Id { get; set; }

        public GetEmployeeByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
