using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.WebApp.Models
{
    public class LoginErrorModel
    {
        public OperationStatusInfo OperationStatus { get; set; }

        public LoginErrorModel(OperationStatusInfo operationStatus)
        {
            OperationStatus = operationStatus;
        }
    }
}
