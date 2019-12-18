using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetCountSuccessProjectTaskByProjectIdModel
    {
        public int ProjectId { get; set; }

        public List<SelectListItem> Projects { get; set; }

        public GetCountSuccessProjectTaskByProjectIdModel()
        {
        }

        public GetCountSuccessProjectTaskByProjectIdModel(List<SelectListItem> projects)
        {
            Projects = projects;
        }
    }
}
