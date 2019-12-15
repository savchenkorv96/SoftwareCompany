using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent
{
    public class CreateProjectRequestEvent
    {
        public Project Project { get; set; }

        public CreateProjectRequestEvent(Project project)
        {
            Project = project;
        }
    }
}
