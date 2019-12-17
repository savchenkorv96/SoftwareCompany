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
using SoftwareCompany.Client.WebApp.Models.TeamModel;

namespace SoftwareCompany.Client.WebApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly HubEnvironment _hubEnvironment;
        public TeamController(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        public IActionResult TeamList()
        {
            OperationStatusInfo op = _hubEnvironment.ServerHubConnector.GetAllTeam().Result;

            if (op.OperationStatus == OperationStatus.Done)
            {
                List<Team> teams = JsonConvert.DeserializeObject<IEnumerable<Team>>(op.AttachedObject.ToString()).ToList();

                return View(new GetAllTeamModelSuccess(teams));
            }

            return View("ErrorLoadList", new GetAllTeamModelFailed(op));
        }

        public IActionResult CreateTeamPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTeam(CreateTeamModel createTeamModel)
        {
            OperationStatusInfo operationStatusInfo = _hubEnvironment.ServerHubConnector.CreateTeam(createTeamModel.Team).Result;

            if (operationStatusInfo.OperationStatus == OperationStatus.Done)
            {
                return TeamList();
            }
            else
            {
                return View("CreateTeamPage", new CreateTeamModel(createTeamModel.Team));
            }

        }
    }
}