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


        public IActionResult GetProjectTaskByEmployeeIdPage()
        {
            List<Employee> teams = JsonConvert
                .DeserializeObject<IEnumerable<Employee>>(_hubEnvironment.ServerHubConnector.GetAllEmployee().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectTeam = teams.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Account.FirstName + " " + s.Account.LastName
            }).ToList();

            return View(new GetProjectTaskByEmployeeIdModel(selectTeam));
        }


        [HttpPost]
        public IActionResult GetProjectTaskByEmployeeIdList(GetProjectTaskByEmployeeIdModel model)
        {
            List<ProjectTask> projects = JsonConvert
                .DeserializeObject<IEnumerable<ProjectTask>>(_hubEnvironment.ServerHubConnector.GetProjectTaskByEmployeeId(model.EmployeeId).Result.AttachedObject.ToString()
                ).ToList();

            return View(new GetProjectTaskByEmployeeIdResultModel(projects));
        }


        public IActionResult GetCountProjectTaskByProjectIdPage()
        {
            List<Project> projects = JsonConvert
                .DeserializeObject<IEnumerable<Project>>(_hubEnvironment.ServerHubConnector.GetAllProject().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectTeam = projects.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Title} ({s.Team.Name})"
            }).ToList();

            return View(new GetCountProjectTaskByProjectIdModel(selectTeam));
        }

        [HttpPost]
        public IActionResult GetCountProjectTaskByProjectIdList(GetCountProjectTaskByProjectIdModel model)
        {
            List<ProjectTask> projects = JsonConvert
                .DeserializeObject<IEnumerable<ProjectTask>>(_hubEnvironment.ServerHubConnector.GetCountProjectTaskByProjectId(model.ProjectId).Result.AttachedObject.ToString()
                ).ToList();

            return View(new GetCountProjectTaskByProjectIdResultModel(projects));
        }


        public IActionResult GetCountSuccessProjectTaskByProjectIdPage()
        {
            List<Project> projects = JsonConvert
                .DeserializeObject<IEnumerable<Project>>(_hubEnvironment.ServerHubConnector.GetAllProject().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectTeam = projects.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Title} ({s.Team.Name})"
            }).ToList();

            return View(new GetCountSuccessProjectTaskByProjectIdModel(selectTeam));
        }

        [HttpPost]
        public IActionResult GetCountSuccessProjectTaskByProjectIdList(GetCountProjectTaskByProjectIdModel model)
        {
            List<ProjectTask> projects = JsonConvert
                .DeserializeObject<IEnumerable<ProjectTask>>(_hubEnvironment.ServerHubConnector.GetCountSuccessProjectTaskByProjectId(model.ProjectId).Result.AttachedObject.ToString()
                ).ToList();

            return View(new GetCountSuccessProjectTaskByProjectIdResultModel(projects));
        }


        public IActionResult GetPercentProjectTaskByProjectIdPage()
        {
            List<Project> projects = JsonConvert
                .DeserializeObject<IEnumerable<Project>>(_hubEnvironment.ServerHubConnector.GetAllProject().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectTeam = projects.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Title} ({s.Team.Name})"
            }).ToList();

            return View(new GetPercentProjectTaskByProjectIdModel(selectTeam));
        }

        [HttpPost]
        public IActionResult GetPercentProjectTaskByProjectIdList(GetPercentProjectTaskByProjectIdModel model)
        {
            List<ProjectTask> projects = JsonConvert
                .DeserializeObject<IEnumerable<ProjectTask>>(_hubEnvironment.ServerHubConnector.GetCountProjectTaskByProjectId(model.ProjectId).Result.AttachedObject.ToString()
                ).ToList();

            return View(new GetPercentProjectTaskByProjectIdResultModel(projects));
        }

        [HttpPost]
        public IActionResult UpdateTaskByIdPage(int taskId)
        {
            ProjectTask task = JsonConvert
                .DeserializeObject<ProjectTask>(_hubEnvironment.ServerHubConnector.GetProjectTaskById(taskId).Result.AttachedObject.ToString()
                );

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

            return View(new UpdateTaskModel(task,task.Project.Id,task.Employee.Id,selectEmployee,selectProject));
        }

        [HttpPost]
        public IActionResult UpdateTaskById(UpdateTaskModel model)
        {
            ProjectTask projectTask = model.ProjectTask;
            projectTask.Employee = new Employee() { Id = model.EmployeeId };
            projectTask.Project = new Project() { Id = model.ProjectId };

            OperationStatusInfo operationStatusInfo = _hubEnvironment.ServerHubConnector.UpdateProjectTask(projectTask).Result;

            if (operationStatusInfo.OperationStatus == OperationStatus.Done)
            {
                return RedirectToAction("TaskList");
            }
            else
            {
                return RedirectToAction("UpdateTaskByIdPage");
            }
        }
    }
}