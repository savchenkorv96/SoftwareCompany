using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TeamModel
{
    public class GetAllTeamModelSuccess
    {
        public List<Team> Teams { get; set; }

        public GetAllTeamModelSuccess(List<Team> teams)
        {
            this.Teams = teams;
        }
    }
}
