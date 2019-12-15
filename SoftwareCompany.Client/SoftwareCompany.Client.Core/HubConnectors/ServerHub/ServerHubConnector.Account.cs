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
        public async Task<Account> Login(string login, string password)
        {
            return await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("Login", new object[] {login, password})
                .ContinueWith<Account>(
                    (data) =>
                    {
                        var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                        Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
                        return account;
                    });
        }

        public async void CreateAccount(Account account)
        {
            await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("CreateAccount", new object[] { account }).ContinueWith(
                (data) =>
                {
                    var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                    Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
                });
        }

        public async void GetAllAccount()
        {
            await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllAccount", new object[] {}).ContinueWith(
                (data) =>
                {
                    var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                    Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
                });
        }

        public async void GetAccountById(int accountId)
        {
            await _hubConnection.InvokeCoreAsync<OperationStatusInfo>("GetAllAccount", new object[] { accountId }).ContinueWith(
                (data) =>
                {
                    var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                    Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
                });
        }
    }
}
