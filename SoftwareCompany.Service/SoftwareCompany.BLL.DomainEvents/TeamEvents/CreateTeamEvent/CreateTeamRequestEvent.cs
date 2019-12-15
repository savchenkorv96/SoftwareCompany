using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent
{
    public class CreateTeamRequestEvent
    {
        public Team Team { get; set; }

        public CreateTeamRequestEvent(Team team)
        {
            Team = team;
        }
    }
}
