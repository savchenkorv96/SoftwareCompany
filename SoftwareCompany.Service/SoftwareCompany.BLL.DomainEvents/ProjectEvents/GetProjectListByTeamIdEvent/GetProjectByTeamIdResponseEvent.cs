using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent
{
    public class GetProjectByTeamIdResponseEvent
    {
        public IEnumerable<Project> Projects { get; set; }

        public GetProjectByTeamIdResponseEvent(IEnumerable<Project> projects)
        {
            Projects = projects;
        }
    }
}
