using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Csla.Blazor.Client.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using KPSL.Collacteral.Shared;
using Csla.Configuration;
using System.Security.Claims;

namespace KPSL.Collacteral.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddAuthorizationCore(config => {
            config.AddPolicy("IsAuthenticated",
            policy => policy.RequireAuthenticatedUser());
            config.AddPolicy("IsAdmin",
            policy => policy.RequireRole("admin", "supervisor", "manager"));
            config.AddPolicy("Thailand",
            policy => policy.RequireClaim(ClaimTypes.Country, "es"));
            });
            builder.Services.AddBaseAddressHttpClient();
            // builder.Services.AddOptions();
            // builder.Services.AddAuthorizationCore();
            builder.Services.AddSingleton
            <AuthenticationStateProvider, CslaAuthenticationStateProvider>();
            builder.Services.AddSingleton<CslaUserService>();

            builder.UseCsla(c =>
                    {
                        c.DataPortal()
                .DefaultProxy(typeof(Csla.DataPortalClient.HttpProxy), "https://localhost:5001/api/dataportaltext/");
                    });

            await builder.Build().RunAsync();
        }
    }
}




