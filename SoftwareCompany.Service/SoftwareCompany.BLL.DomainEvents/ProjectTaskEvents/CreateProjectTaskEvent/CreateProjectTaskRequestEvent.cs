using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent
{
    public class CreateProjectTaskRequestEvent
    {
        public ProjectTask ProjectTask { get; set; }

        public CreateProjectTaskRequestEvent(ProjectTask projectTask)
        {
            ProjectTask = projectTask;
        }
    }
}
