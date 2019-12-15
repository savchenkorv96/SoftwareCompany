using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent
{
    public class UpdateProjectTaskResponseEvent
    {
        public bool Status { get; set; }

        public UpdateProjectTaskResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
