using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent
{
    public class UpdateProjectResponseEvent
    {
        public bool Status { get; set; }

        public UpdateProjectResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
