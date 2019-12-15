using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent
{
    public class GetProjectByIdResponseEvent
    {
        public Project Project { get; set; }

        public GetProjectByIdResponseEvent(Project project)
        {
            Project = project;
        }
    }
}
