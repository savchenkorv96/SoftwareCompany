using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.Core.HubConnectors.ServerHub
{
    partial class ServerHubConnector
    {
        public async Task<OperationStatusInfo> CreateEmployee(Employee employee)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateEmployee", new object[] { employee });
        }
        public async Task<OperationStatusInfo> GetAllEmployee()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllEmployee", new object[] { });
        }
        public async Task<OperationStatusInfo> GetEmployeeById(int id)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetEmployeeById", new object[] { id });
        }
        public async Task<OperationStatusInfo> GetEmployeeByAccountId(int accountId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetEmployeeByAccountId", new object[] { accountId });
        }
        public async Task<OperationStatusInfo> GetCountEmployeeByTeamId(int id)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetCountEmployeeByTeamId", new object[] { id });
        }
    }
}
