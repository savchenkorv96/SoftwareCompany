using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.Core.HubConnectors.ServerHub
{
    partial class ServerHubConnector
    {
        public async Task<OperationStatusInfo> Login(string login, string password)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("Login", new object[] {login, password});
        }

        public async Task<OperationStatusInfo> CreateAccount(Account account)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateAccount", new object[] { account });
        }

        public async Task<OperationStatusInfo> GetAllAccount()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllAccount", new object[] {});
        }

        public async Task<OperationStatusInfo> GetAccountById(int accountId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAccountById", new object[] { accountId });
        }
    }
}
