using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Helpers;

using Microsoft.AspNetCore.SignalR.Client;

namespace SoftwareCompany.Client.Core.HubConnectors.ServerHub
{
    partial class ServerHubConnector
    {
        public async Task<OperationStatusInfo> GetAllCustomer()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllCustomer", new object[] { });
        }

        public async Task<OperationStatusInfo> GetCustomerById(int customerId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetCustomerById", new object[] { customerId });
        }
    }
}
