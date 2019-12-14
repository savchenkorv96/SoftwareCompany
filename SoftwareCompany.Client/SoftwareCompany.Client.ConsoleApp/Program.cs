using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Helpers;

namespace SoftwareCompany.Client.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(Run);
            Console.ReadLine();
        }

        static async Task Run()
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5001/ServerHub")
                .Build();
            //connection.On<string, string>("GetAccountByLoginAndPassword", (login, password) => { Console.WriteLine(login); });

            await connection.StartAsync();

           await connection.InvokeCoreAsync<OperationStatusInfo>("Login", new object[] {"user1", "password1"}).ContinueWith(
               (data) =>
               {
                   var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
                   Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
               });



        }
    }
}
