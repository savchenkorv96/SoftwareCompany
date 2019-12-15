using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent
{
    public class GetAllTeamResponseEvent
    {
        public IEnumerable<Team> Teams { get; set; }

        public GetAllTeamResponseEvent(IEnumerable<Team> teams)
        {
            Teams = teams;
        }
    }
}
