using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent
{
    public class GetProjectByIdRequestEvent
    {
        public int Id { get; set; }

        public GetProjectByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
