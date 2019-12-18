using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent
{
    public class GetCountSuccessTaskByProjectIdResponseEvent
    {
        public IEnumerable<ProjectTask> SuccessTasks { get; set; }

        public GetCountSuccessTaskByProjectIdResponseEvent(IEnumerable<ProjectTask> successTasks)
        {
            SuccessTasks = successTasks;
        }
    }
}
