using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.Client.Core.HubConnectors.ServerHub;

namespace SoftwareCompany.Client.Core.HubConnectors
{
    public class HubEnvironment
    {
        public ServerHubConnector ServerHubConnector { get; set; }

        public HubEnvironment()
        {
            ServerHubConnector = new ServerHubConnector("127.0.0.1",8001,"ServerHub");
            ServerHubConnector.GetConnection();
        }
    }
}
