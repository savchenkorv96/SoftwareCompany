using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class UpdateTaskModel
    {
        public ProjectTask ProjectTask { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }

        public List<SelectListItem> Employee { get; set; }
        public List<SelectListItem> Project { get; set; }

        public UpdateTaskModel()
        {
        }

        public UpdateTaskModel(ProjectTask projectTask, List<SelectListItem> employee, List<SelectListItem> project)
        {
            ProjectTask = projectTask;
            Employee = employee;
            Project = project;
        }

        public UpdateTaskModel(ProjectTask projectTask, int projectId, int employeeId, List<SelectListItem> employee, List<SelectListItem> project)
        {
            ProjectTask = projectTask;
            ProjectId = projectId;
            EmployeeId = employeeId;
            Employee = employee;
            Project = project;
        }
    }
}
