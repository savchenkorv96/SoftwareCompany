using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent
{
    public class GetTaskListByEmployeeIdResponseEvent
    {
        public IEnumerable<ProjectTask> ProjectTasks { get; set; }

        public GetTaskListByEmployeeIdResponseEvent(IEnumerable<ProjectTask> projectTasks)
        {
            ProjectTasks = projectTasks;
        }
    }
}
