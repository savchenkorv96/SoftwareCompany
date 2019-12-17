using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.ProjectModel
{
    public class GetProjectByTeamIdModel
    {
        public List<SelectListItem> Teams { get; set; }
        public int TeamId { get; set; }

        public GetProjectByTeamIdModel(List<SelectListItem> teams)
        {
            Teams = teams;
        }

        public GetProjectByTeamIdModel()
        {
        }
    }
}
