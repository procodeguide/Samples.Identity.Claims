using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProCodeGuide.Sample.Blog.Areas.Identity.Data;
using ProCodeGuide.Sample.Blog.Data;

[assembly: HostingStartup(typeof(ProCodeGuide.Sample.Blog.Areas.Identity.IdentityHostingStartup))]
namespace ProCodeGuide.Sample.Blog.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SampleAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SampleAppContextConnection")));

                services.AddDefaultIdentity<SampleAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SampleAppContext>();

                services.AddScoped<IUserClaimsPrincipalFactory<SampleAppUser>,
                    ApplicationUserClaimsPrincipalFactory
                    >();
            });
        }
    }
}