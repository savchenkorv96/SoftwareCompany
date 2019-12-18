using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;
using SoftwareCompany.Client.Core.HubConnectors;
using SoftwareCompany.Client.WebApp.Infrasctucture;
using SoftwareCompany.Client.WebApp.Models;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public LoginController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.Login(loginModel.Login, loginModel.Password).Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                Account account = JsonConvert.DeserializeObject<Account>(op.AttachedObject.ToString());
                HttpContext.Session.SetJson("account", account);
                Employee employee = JsonConvert.DeserializeObject<Employee>(_hubEnvironment.ServerHubConnector.GetEmployeeByAccountId(account.Id).Result.AttachedObject.ToString());
                HttpContext.Session.SetJson("employee", employee);
                return Redirect("/Home");
            }
            else
            {
                return View("Error", new LoginErrorModel(op));
            }

        }
    }
}