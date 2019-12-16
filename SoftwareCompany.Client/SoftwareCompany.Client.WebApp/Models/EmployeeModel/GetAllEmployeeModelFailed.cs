using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models.EmployeeModel
{
    public class GetAllEmployeeModelFailed
    {
        public OperationStatusInfo operationStatusInfo { get; set; }

        public GetAllEmployeeModelFailed(OperationStatusInfo operationStatusInfo)
        {
            this.operationStatusInfo = operationStatusInfo;
        }
    }
}
