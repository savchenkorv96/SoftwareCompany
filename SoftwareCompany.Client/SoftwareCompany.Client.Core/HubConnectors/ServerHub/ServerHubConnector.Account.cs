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
        public async void Login(string login, string password)
        {
            await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("Login", new object[] { login, password }).ContinueWith(
                (data) =>
                {
                    var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                    Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
                });
        }
    }
}
