using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent
{
    public class GetCountSuccessTaskByProjectIdRequestEvent
    {
        public int ProjectId { get; set; }

        public GetCountSuccessTaskByProjectIdRequestEvent(int projectId)
        {
            ProjectId = projectId;
        }
    }
}
