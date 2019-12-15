using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent
{
    public class CreateProjectTaskResponseEvent
    {
        public bool Status { get; set; }

        public CreateProjectTaskResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
