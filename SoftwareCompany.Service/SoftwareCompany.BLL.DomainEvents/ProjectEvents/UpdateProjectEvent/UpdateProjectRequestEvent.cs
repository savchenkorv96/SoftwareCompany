using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent
{
    public class UpdateProjectRequestEvent
    {
        public Project Project { get; set; }

        public UpdateProjectRequestEvent(Project project)
        {
            Project = project;
        }
    }
}
