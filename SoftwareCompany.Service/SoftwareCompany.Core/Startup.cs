using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwareCompany.Core.Environment;
using SoftwareCompany.Core.Hubs.ServerHub;
using SoftwareCompany.DAL.Core;
using SoftwareCompany.DAL.Core.Data;

namespace SoftwareCompany.Core
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSignalR(hubOptions =>
            {
                hubOptions.EnableDetailedErrors = true;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration["Data:SqlLite:ConnectionString"], b => b.MigrationsAssembly("SoftwareCompany.Service")));

            services.AddSingleton<HubEnvironment>();
        }

        public void Configure(IApplicationBuilder app)
        {
            SeedData.EnsurePopulated(app);

            app.UseSignalR(routes =>
            {
                routes.MapHub<ServerHub>("/ServerHub", options => {});
            });
        }
    }
}
