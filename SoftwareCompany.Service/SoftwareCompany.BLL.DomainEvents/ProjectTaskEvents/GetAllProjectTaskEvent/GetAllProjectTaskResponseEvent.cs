using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent
{
    public class GetAllProjectTaskResponseEvent
    {
        public IEnumerable<ProjectTask> ProjectTasks { get; set; }

        public GetAllProjectTaskResponseEvent(IEnumerable<ProjectTask> projectTasks)
        {
            ProjectTasks = projectTasks;
        }
    }
}
