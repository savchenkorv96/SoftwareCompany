using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent
{
    public class GetAllProjectResponseEvent
    {
        public IEnumerable<Project> Projects { get; set; }

        public GetAllProjectResponseEvent(IEnumerable<Project> projects)
        {
            Projects = projects;
        }
    }
}
