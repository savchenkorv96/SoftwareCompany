using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.ProjectModel
{
    public class CreateProjectModel
    {
        public Project Project { get; set; }
        public int EmployeeId { get; set; }
        public int TeamId { get; set; }
        public int CustomerId { get; set; }

        public List<SelectListItem> Employee { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> Teams { get; set; }

        public CreateProjectModel()
        {
        }

        public CreateProjectModel(Project project, List<SelectListItem> employee, List<SelectListItem> customers, List<SelectListItem> teams)
        {
            Project = project;
            Employee = employee;
            Customers = customers;
            Teams = teams;
        }
    }
}
