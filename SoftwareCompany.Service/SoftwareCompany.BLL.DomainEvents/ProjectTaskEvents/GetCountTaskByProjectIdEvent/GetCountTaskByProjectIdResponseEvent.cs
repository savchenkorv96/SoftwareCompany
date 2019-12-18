using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent
{
    public class GetCountTaskByProjectIdResponseEvent
    {
        public IEnumerable<ProjectTask> Tasks { get; set; }

        public GetCountTaskByProjectIdResponseEvent(IEnumerable<ProjectTask> tasks)
        {
            Tasks = tasks;
        }
    }
}
