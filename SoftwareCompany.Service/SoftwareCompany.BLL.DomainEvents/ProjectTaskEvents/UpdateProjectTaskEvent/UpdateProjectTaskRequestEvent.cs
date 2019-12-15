using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent
{
    public class UpdateProjectTaskRequestEvent
    {
        public ProjectTask ProjectTask { get; set; }

        public UpdateProjectTaskRequestEvent(ProjectTask projectTask)
        {
            ProjectTask = projectTask;
        }
    }
}
