using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TeamModel
{
    public class CreateTeamModel
    {
        public Team Team { get; set; }
        public CreateTeamModel()
        {
        }
        public CreateTeamModel(Team team)
        {
            Team = team;
        }
    }
}
