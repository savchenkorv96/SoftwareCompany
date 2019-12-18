using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetPercentProjectTaskByProjectIdModel
    {
        public int ProjectId { get; set; }

        public List<SelectListItem> Projects { get; set; }

        public GetPercentProjectTaskByProjectIdModel()
        {
        }

        public GetPercentProjectTaskByProjectIdModel(List<SelectListItem> projects)
        {
            Projects = projects;
        }
    }
}
