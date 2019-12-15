using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Enumerations;
using SoftwareCompany.Client.Common.Helpers;
using SoftwareCompany.Client.Core.HubConnectors.ServerHub;

namespace SoftwareCompany.Client.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerHubConnector serverHubConnector = new ServerHubConnector("127.0.0.1",8001,"ServerHub");
            serverHubConnector.GetConnection();
            serverHubConnector.Login("user1","password1");
            Console.ReadLine();
        }

        static async Task Run()
        {
            //await connection.InvokeCoreAsync<OperationStatusInfo>("Login", new object[] { "user1", "password1" }).ContinueWith(
            //    (data) =>
            //    {
            //        var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
            //        Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
            //    });

            //await connection.InvokeCoreAsync<OperationStatusInfo>("CreateAccount", new object[] { new Account(){Login = "login", Password = "password", FirstName = "FirstName", LastName = "LastName", Email = "email@gmail.com", Phone = "380684569332", Skype = "test37", Type = AccountType.Customer}}).ContinueWith(
            //   (data) =>
            //   {
            //       if (data.Result.OperationStatus == OperationStatus.Cancelled)
            //       {
            //           Console.WriteLine(data.Result.AttachedInfo);
            //       }
            //       else
            //       {

            //           var stasus = data.Result.AttachedObject;
            //           Console.WriteLine($"{stasus}");
            //       }
            //   });


            //await connection.InvokeCoreAsync<OperationStatusInfo>("GetAccountById", new object[] { 13 }).ContinueWith(
            //    (data) =>
            //    {
            //        if (data.Result.OperationStatus == OperationStatus.Done)
            //        {
            //            var account = JsonConvert.DeserializeObject<Account>(data.Result.AttachedObject.ToString());
            //            Console.WriteLine($"{account.Id}\t{account.Login}\t{account.Password}");
            //        }
            //        else
            //        {
            //            Console.WriteLine(data.Result.AttachedInfo);
            //        }
            //    });

            //await connection.InvokeCoreAsync<OperationStatusInfo>("GetAllAccount", new object[]{}).ContinueWith(
            //    (data) =>
            //    {
            //        if (data.Result.OperationStatus == OperationStatus.Done)
            //        {
            //            IEnumerable<Account> account = JsonConvert.DeserializeObject<IEnumerable<Account>>(data.Result.AttachedObject.ToString());
            //            foreach (var VARIABLE in account)
            //            {
            //                Console.WriteLine($"{VARIABLE.Id}\t{VARIABLE.Login}\t{VARIABLE.Password}");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine(data.Result.AttachedInfo);
            //        }
            //    });

            //await connection.InvokeCoreAsync<OperationStatusInfo>("GetAllEmployee", new object[] { }).ContinueWith(
            //    (data) =>
            //    {
            //        if (data.Result.OperationStatus == OperationStatus.Done)
            //        {
            //            IEnumerable<Employee> account = JsonConvert.DeserializeObject<IEnumerable<Employee>>(data.Result.AttachedObject.ToString());
            //            foreach (var VARIABLE in account)
            //            {
            //                Console.WriteLine($"{VARIABLE.Id}\t{VARIABLE.Team.Name}\t{VARIABLE.Position}");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine(data.Result.AttachedInfo);
            //        }
            //    });

            //await connection.InvokeCoreAsync<OperationStatusInfo>("GetEmployeeById", new object[] { 1 }).ContinueWith(
            //    (data) =>
            //    {
            //        if (data.Result.OperationStatus == OperationStatus.Done)
            //        {
            //            var account = JsonConvert.DeserializeObject<Employee>(data.Result.AttachedObject.ToString());
            //            Console.WriteLine($"{account.Id}\t{account.Account.Login}\t{account.Account.Password}");
            //        }
            //        else
            //        {
            //            Console.WriteLine(data.Result.AttachedInfo);
            //        }
            //    });

            //await connection.InvokeCoreAsync<OperationStatusInfo>("GetEmployeeByAccountId", new object[] { 1 }).ContinueWith(
            //    (data) =>
            //    {
            //        if (data.Result.OperationStatus == OperationStatus.Done)
            //        {
            //            var account = JsonConvert.DeserializeObject<Employee>(data.Result.AttachedObject.ToString());
            //            Console.WriteLine($"{account.Id}\t{account.Account.Login}\t{account.Account.Password}");
            //        }
            //        else
            //        {
            //            Console.WriteLine(data.Result.AttachedInfo);
            //        }
            //    });
        }
    }
}
