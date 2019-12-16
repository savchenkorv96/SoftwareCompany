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
        public async Task<OperationStatusInfo> CreateProject(Project project)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateProject", new object[] { project });
        }
        public async Task<OperationStatusInfo> UpdateProject(Project project)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("UpdateProject", new object[] { project });
        }
        public async Task<OperationStatusInfo> GetAllProject()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllProject", new object[] { });
        }
        public async Task<OperationStatusInfo> GetProjectById(int id)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetProjectById", new object[] { id });
        }
        public async Task<OperationStatusInfo> GetProjectByTeamId(int teamId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetProjectByTeamId", new object[] { teamId });
        }
    }
}
