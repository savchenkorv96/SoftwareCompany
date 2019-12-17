using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;
using SoftwareCompany.Client.Core.HubConnectors;
using SoftwareCompany.Client.WebApp.Models.AccountModel;
using SoftwareCompany.Client.WebApp.Models.EmployeeModel;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public EmployeeController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        public IActionResult EmployeeList()
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.GetAllEmployee().Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                List<Employee> employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(op.AttachedObject.ToString()).ToList();

                return View(new GetAllEmployeeModelSuccess(employees));
            }

            return View("ErrorLoadList", new GetAllEmployeeModelFailed(op));
        }

        public IActionResult CreateEmployeePage()
        {
            List<Account> accounts = JsonConvert
                .DeserializeObject<IEnumerable<Account>>(_hubEnvironment.ServerHubConnector.GetAllAccount().Result.AttachedObject.ToString()
                ).ToList();
            List<Team> teams = JsonConvert
                .DeserializeObject<IEnumerable<Team>>(_hubEnvironment.ServerHubConnector.GetAllTeam().Result.AttachedObject.ToString()
                ).ToList();

            List< SelectListItem > selectAccount = accounts.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = $"{s.FirstName} {s.LastName}"
            }).ToList();

            List<SelectListItem> selectTeam = teams.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            return View(new CreateEmployeeModel(selectAccount,selectTeam ));
        }

        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeModel createEmployeeModel)
        {
           
            Employee employee = createEmployeeModel.Employee;
            employee.Account = new Account(){Id = createEmployeeModel.AccountId};
            employee.Team = new Team(){Id = createEmployeeModel.TeamId};
            employee.DateOfEmployment = DateTime.Now;

            OperationStatusInfo operationStatusInfo = _hubEnvironment.ServerHubConnector.CreateEmployee(employee).Result;

            if (operationStatusInfo.OperationStatus == OperationStatus.Done)
            {
                return EmployeeList();
            }
            else
            {
                return CreateEmployeePage();
            }

        }
    }
}