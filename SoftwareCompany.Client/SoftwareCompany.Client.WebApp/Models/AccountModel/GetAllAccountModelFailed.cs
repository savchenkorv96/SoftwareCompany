using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models.AccountModel
{
    public class GetAllAccountModelFailed
    {
        public OperationStatusInfo operationStatusInfo { get; set; }

        public GetAllAccountModelFailed(OperationStatusInfo operationStatusInfo)
        {
            this.operationStatusInfo = operationStatusInfo;
        }
    }
}
