using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetCountSuccessProjectTaskByProjectIdResultModel
    {
        public List<ProjectTask> ProjectTasks { get; set; }

        public GetCountSuccessProjectTaskByProjectIdResultModel()
        {
        }

        public GetCountSuccessProjectTaskByProjectIdResultModel(List<ProjectTask> projectTasks)
        {
            ProjectTasks = projectTasks;
        }
    }
}
