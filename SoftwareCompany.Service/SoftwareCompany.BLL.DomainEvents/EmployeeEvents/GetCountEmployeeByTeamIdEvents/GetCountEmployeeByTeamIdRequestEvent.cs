using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents
{
    public class GetCountEmployeeByTeamIdRequestEvent
    {
        public int TeamId { get; set; }

        public GetCountEmployeeByTeamIdRequestEvent(int teamId)
        {
            TeamId = teamId;
        }
    }
}
