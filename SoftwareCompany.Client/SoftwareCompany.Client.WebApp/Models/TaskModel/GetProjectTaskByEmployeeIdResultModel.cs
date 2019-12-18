using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetProjectTaskByEmployeeIdResultModel
    {
        public List<ProjectTask> Tasks { get; set; }

        public GetProjectTaskByEmployeeIdResultModel(List<ProjectTask> tasks)
        {
            Tasks = tasks;
        }
    }
}
