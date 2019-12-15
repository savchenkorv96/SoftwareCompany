using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent
{
    public class GetTeamByIdResponseEvent
    {
        public Team Team { get; set; }

        public GetTeamByIdResponseEvent(Team team)
        {
            Team = team;
        }
    }
}
