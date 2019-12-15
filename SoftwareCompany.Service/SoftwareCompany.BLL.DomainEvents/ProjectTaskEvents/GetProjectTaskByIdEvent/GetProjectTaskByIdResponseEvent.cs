using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent
{
    public class GetProjectTaskByIdResponseEvent
    {
        public ProjectTask ProjectTask { get; set; }

        public GetProjectTaskByIdResponseEvent(ProjectTask projectTask)
        {
            ProjectTask = projectTask;
        }
    }
}
