using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;
using SoftwareCompany.Client.Core.HubConnectors;
using SoftwareCompany.Client.WebApp.Models.TaskModel;
using SoftwareCompany.Client.WebApp.Models.TeamModel;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public TaskController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        public IActionResult TaskList()
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.GetAllProjectTask().Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                List<ProjectTask> projectTasks = JsonConvert.DeserializeObject<IEnumerable<ProjectTask>>(op.AttachedObject.ToString()).ToList();

                return View(new GetAllTaskModelSuccess(projectTasks));
            }

            return View("ErrorLoadList", new GetAllTaskModelFailed(op));
        }
    }
}