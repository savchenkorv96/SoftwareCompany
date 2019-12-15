using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent
{
    public class GetCountTaskByProjectIdRequestEvent
    {
        public int ProjectId { get; set; }

        public GetCountTaskByProjectIdRequestEvent(int projectId)
        {
            ProjectId = projectId;
        }
    }
}
