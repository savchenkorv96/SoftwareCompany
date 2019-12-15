using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents
{
    public class GetCountEmployeeByTeamIdResponseEvent
    {
        public int CountEmployee { get; set; }

        public GetCountEmployeeByTeamIdResponseEvent(int countEmployee)
        {
            CountEmployee = countEmployee;
        }
    }
}
