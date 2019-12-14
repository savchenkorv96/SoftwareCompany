using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

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

           await connection.InvokeCoreAsync("Login", new object[] {"user1", "password1"});



        }
    }
}
