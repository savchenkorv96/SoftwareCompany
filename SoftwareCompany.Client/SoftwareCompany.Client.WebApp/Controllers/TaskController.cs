using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult CreateTaskPage()
        {
            List<Employee> employees = JsonConvert
                .DeserializeObject<IEnumerable<Employee>>(_hubEnvironment.ServerHubConnector.GetAllEmployee().Result.AttachedObject.ToString()
                ).ToList();

            List<Project> projects = JsonConvert
                .DeserializeObject<IEnumerable<Project>>(_hubEnvironment.ServerHubConnector.GetAllProject().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectEmployee = employees.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Account.FirstName} {s.Account.LastName}"
            }).ToList();

            List<SelectListItem> selectProject = projects.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"Title:{s.Title} Team:({s.Team.Name})"
            }).ToList();

            return View(new CreateTaskModel(new ProjectTask(), selectEmployee,selectProject));
        }

        [HttpPost]
        public IActionResult CreateTask(CreateTaskModel createProjectModel)
        {
            ProjectTask projectTask = createProjectModel.ProjectTask;
            projectTask.Employee = new Employee() { Id = createProjectModel.EmployeeId };
            projectTask.Project = new Project() { Id = createProjectModel.ProjectId };

            OperationStatusInfo operationStatusInfo = _hubEnvironment.ServerHubConnector.CreateProjectTask(projectTask).Result;

            if (operationStatusInfo.OperationStatus == OperationStatus.Done)
            {
                return RedirectToAction("TaskList");
            }
            else
            {
                return RedirectToAction("CreateTaskPage");
            }
        }
    }
}