using System;
using CommerceProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CommerceProject.Areas.Identity.IdentityHostingStartup))]
namespace CommerceProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CommerceProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CommerceProjectContextConnection")));

               //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                 //   .AddEntityFrameworkStores<CommerceProjectContext>();
            });
        }
    }
}