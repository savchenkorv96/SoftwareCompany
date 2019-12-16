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
        public async Task<OperationStatusInfo> CreateProjectTask(ProjectTask projectTask)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateProjectTask", new object[] { projectTask });
        }
        public async Task<OperationStatusInfo> UpdateProjectTask(ProjectTask projectTask)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("UpdateProjectTask", new object[] { projectTask });
        }

        public async Task<OperationStatusInfo> GetAllProjectTask()
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllProjectTask", new object[] { });
        }
        public async Task<OperationStatusInfo> GetProjectTaskById(int id)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetProjectTaskById", new object[] { id });
        }
        public async Task<OperationStatusInfo> GetProjectTaskByEmployeeId(int employeeId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetProjectTaskByEmployeeId", new object[] { employeeId });
        }
        public async Task<OperationStatusInfo> GetCountProjectTaskByProjectId(int projectId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetCountProjectTaskByProjectId", new object[] { projectId });
        }
        public async Task<OperationStatusInfo> GetCountSuccessProjectTaskByProjectId(int projectId)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetCountSuccessProjectTaskByProjectId", new object[] { projectId });
        }


    }
}
