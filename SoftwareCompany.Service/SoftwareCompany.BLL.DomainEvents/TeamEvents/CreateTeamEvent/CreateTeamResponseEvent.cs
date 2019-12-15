using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent
{
    public class CreateTeamResponseEvent
    {
        public bool Status { get; set; }

        public CreateTeamResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
