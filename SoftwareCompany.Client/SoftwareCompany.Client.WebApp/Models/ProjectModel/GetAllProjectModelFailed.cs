using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models.ProjectModel
{
    public class GetAllProjectModelFailed
    {
        public OperationStatusInfo operationStatusInfo { get; set; }

        public GetAllProjectModelFailed(OperationStatusInfo operationStatusInfo)
        {
            this.operationStatusInfo = operationStatusInfo;
        }
    }
}
