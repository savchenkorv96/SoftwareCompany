using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.ProjectModel
{
    public class GetProjectByTeamIdResultModel
    {
        public List<Project> Projects { get; set; }

        public GetProjectByTeamIdResultModel(List<Project> projects)
        {
            Projects = projects;
        }
    }
}
