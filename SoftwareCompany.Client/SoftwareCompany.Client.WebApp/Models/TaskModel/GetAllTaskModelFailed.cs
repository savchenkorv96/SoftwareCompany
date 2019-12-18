using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetAllTaskModelFailed
    {
        public OperationStatusInfo operationStatusInfo { get; set; }

        public GetAllTaskModelFailed(OperationStatusInfo operationStatusInfo)
        {
            this.operationStatusInfo = operationStatusInfo;
        }
    }
}
