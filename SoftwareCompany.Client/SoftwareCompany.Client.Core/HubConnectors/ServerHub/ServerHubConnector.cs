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
    public partial class ServerHubConnector
    {
        public HubConnection _hubConnection { get; set; }
        public string Url { get; set; }
        public int Port { get; set; }
        public string ServerUrl { get; set; } 
        public string HubName { get; set; }
        public string ServerHubUrl { get; set; }

        public ServerHubConnector(string url, int port, string hubName)
        {
            this.Url = url;
            this.Port = port;
            this.ServerUrl = $"http://{Url}:{Port}";
            this.HubName = hubName;
            this.ServerHubUrl = $"{ServerUrl}/{HubName}";
            BuildConnection();
        }


        public void BuildConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(ServerHubUrl, options => { options.Transports = HttpTransportType.WebSockets; })
                .Build();
        }

        public async void GetConnection()
        {
            await _hubConnection.StartAsync();
        }

        public async void CloseConnection()
        {
            await _hubConnection.StopAsync();
        }

        
    }
}
