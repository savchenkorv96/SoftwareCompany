using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.SignalR;
using SoftwareCompany.Core.Environment;

namespace SoftwareCompany.Core.Hubs.ServerHub
{
    public partial class ServerHub : Hub
    {
        /// <summary>
        /// The connection collection. Stores the active connections.
        /// </summary>
        private static readonly List<string> ConnectionCollection = new List<string>();

        /// <summary>
        /// The locker.
        /// </summary>
        private static readonly object Locker = new object();
        private readonly HubEnvironment _hubEnvironment;

        public ServerHub(HubEnvironment hubEnvironment)
        {
            this._hubEnvironment = hubEnvironment;
        }
        
        private void AddConnection(string connectionId)
        {
            lock (Locker)
            {
                if (!ConnectionCollection.Contains(connectionId))
                {
                    ConnectionCollection.Add(connectionId);
                }
            }
        }

        private void RemoveConnection(string connectionId)
        {
            lock (Locker)
            {
                if (ConnectionCollection.Contains(connectionId))
                {
                    ConnectionCollection.Remove(connectionId);
                }
            }
        }

        private string GetIpAddress()
        {
            var ipAddress = Context.GetHttpContext().Connection.RemoteIpAddress.ToString();

            return ipAddress;
        }
    }
}
