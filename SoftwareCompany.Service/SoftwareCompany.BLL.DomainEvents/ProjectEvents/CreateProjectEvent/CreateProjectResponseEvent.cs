using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent
{
    public class CreateProjectResponseEvent
    {
        public bool Status { get; set; }

        public CreateProjectResponseEvent(bool status)
        {
            Status = status;
        }
    }
}
