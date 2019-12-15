using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent
{
    public class GetProjectTaskByIdRequestEvent
    {
        public int Id { get; set; }

        public GetProjectTaskByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
