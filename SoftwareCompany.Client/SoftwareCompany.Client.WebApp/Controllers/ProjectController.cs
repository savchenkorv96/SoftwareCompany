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
using SoftwareCompany.Client.WebApp.Models.ProjectModel;
using SoftwareCompany.Client.WebApp.Models.TeamModel;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public ProjectController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }

        public IActionResult ProjectList()
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.GetAllProject().Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                List<Project> projects = JsonConvert.DeserializeObject<IEnumerable<Project>>(op.AttachedObject.ToString()).ToList();

                return View(new GetAllProjectModelSuccess(projects));
            }

            return View("ErrorLoadList", new GetAllProjectModelFailed(op));
        }

        public IActionResult GetProjectByTeamIdPage()
        {
            List<Team> teams = JsonConvert
                .DeserializeObject<IEnumerable<Team>>(_hubEnvironment.ServerHubConnector.GetAllTeam().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectTeam = teams.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            return View(new GetProjectByTeamIdModel(selectTeam));
        }

        public IActionResult GetProjectByTeamIdList(GetProjectByTeamIdModel model)
        {
            List<Project> projects = JsonConvert
                .DeserializeObject<IEnumerable<Project>>(_hubEnvironment.ServerHubConnector.GetProjectByTeamId(model.TeamId).Result.AttachedObject.ToString()
                ).ToList();

            return View(new GetProjectByTeamIdResultModel(projects));
        }

        public IActionResult CreateProjectPage()
        {
            List<Customer> customers = JsonConvert
                .DeserializeObject<IEnumerable<Customer>>(_hubEnvironment.ServerHubConnector.GetAllCustomer().Result.AttachedObject.ToString()
                ).ToList();
            List<Team> teams = JsonConvert
                .DeserializeObject<IEnumerable<Team>>(_hubEnvironment.ServerHubConnector.GetAllTeam().Result.AttachedObject.ToString()
                ).ToList();
            List<Employee> employees = JsonConvert
                .DeserializeObject<IEnumerable<Employee>>(_hubEnvironment.ServerHubConnector.GetAllEmployee().Result.AttachedObject.ToString()
                ).ToList();

            List<SelectListItem> selectCustomer = customers.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Account.FirstName} {s.Account.LastName} ({s.Account.Phone})"
            }).ToList();

            List<SelectListItem> selectTeam = teams.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            List<SelectListItem> selectEmployee = employees.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.Account.FirstName} {s.Account.LastName} ({s.Account.Phone})"
            }).ToList();

            return View(new CreateProjectModel(new Project(), selectEmployee, selectCustomer, selectTeam));
        }

        public IActionResult CreateProject(CreateProjectModel createProjectModel)
        {

            Project project = createProjectModel.Project;
            project.Manager = new Employee() { Id = createProjectModel.EmployeeId };
            project.Customer = new Customer() { Id = createProjectModel.CustomerId };
            project.Team = new Team() { Id = createProjectModel.TeamId };

            OperationStatusInfo operationStatusInfo = _hubEnvironment.ServerHubConnector.CreateProject(project).Result;

            if (operationStatusInfo.OperationStatus == OperationStatus.Done)
            {
                return RedirectToAction("ProjectList");
            }
            else
            {
                return CreateProjectPage();
            }
        }
    }
}