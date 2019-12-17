using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models.TeamModel
{
    public class GetAllTeamModelFailed
    {
        public OperationStatusInfo operationStatusInfo { get; set; }

        public GetAllTeamModelFailed(OperationStatusInfo operationStatusInfo)
        {
            this.operationStatusInfo = operationStatusInfo;
        }
    }
}
