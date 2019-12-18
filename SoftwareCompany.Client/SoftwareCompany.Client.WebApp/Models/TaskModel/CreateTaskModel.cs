using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class CreateTaskModel
    {
        public ProjectTask ProjectTask { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }

        public List<SelectListItem> Employee { get; set; }
        public List<SelectListItem> Project { get; set; }

        public CreateTaskModel()
        {
        }

        public CreateTaskModel(ProjectTask projectTask, List<SelectListItem> employee, List<SelectListItem> project)
        {
            ProjectTask = projectTask;
            Employee = employee;
            Project = project;
        }
    }
}
