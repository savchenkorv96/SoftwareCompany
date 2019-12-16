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
        public async Task<OperationStatusInfo> CreateTeam(Team team)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateTeam", new object[] { team });
        }

        public async Task<OperationStatusInfo> GetAllTeam()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllTeam", new object[] {});
        }

        public async Task<OperationStatusInfo> GetTeamById(int id)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetTeamById", new object[] { id });
        }
    }
}
