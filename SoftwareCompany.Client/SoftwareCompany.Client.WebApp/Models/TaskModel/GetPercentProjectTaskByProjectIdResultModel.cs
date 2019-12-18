using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetPercentProjectTaskByProjectIdResultModel
    {
        public List<ProjectTask> ProjectTask { get; set; }

        public GetPercentProjectTaskByProjectIdResultModel(List<ProjectTask> projectTask)
        {
            ProjectTask = projectTask;
        }

        public GetPercentProjectTaskByProjectIdResultModel()
        {
        }
    }
}
