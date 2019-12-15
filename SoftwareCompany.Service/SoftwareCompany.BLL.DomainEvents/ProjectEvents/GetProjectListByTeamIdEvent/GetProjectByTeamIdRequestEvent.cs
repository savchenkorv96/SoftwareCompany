using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent
{
    public class GetProjectByTeamIdRequestEvent
    {
        public int TeamId { get; set; }

        public GetProjectByTeamIdRequestEvent(int teamId)
        {
            TeamId = teamId;
        }
    }
}
