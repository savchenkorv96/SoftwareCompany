using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}