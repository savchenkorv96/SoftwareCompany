﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;
using SoftwareCompany.Client.Core.HubConnectors;
using SoftwareCompany.Client.WebApp.Models.AccountModel;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public AccountController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        public IActionResult AccountList()
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.GetAllAccount().Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                List<Account> account = JsonConvert.DeserializeObject<IEnumerable<Account>>(op.AttachedObject.ToString()).ToList();
                
                return View(new GetAllAccountModelSuccess(account));
            }

            return View("Error", new GetAllAccountModelFailed(op));

        }
    }
}