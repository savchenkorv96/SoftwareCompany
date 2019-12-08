using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using SoftwareCompany.Core;

namespace SoftwareCompany.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5001");
        }
    }
}
