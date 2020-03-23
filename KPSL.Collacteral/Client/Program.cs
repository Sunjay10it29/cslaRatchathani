using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Csla.Blazor.Client.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using KPSL.Collacteral.Shared;
using Csla.Configuration;
using System.Security.Claims;
using Csla;
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
            builder.Services.AddSingleton<AuthenticationStateProvider, CurrentUserAuthenticationStateProvider>();
        //    var authStateProvider = builder.RootComponents.GetRequiredService<AuthenticationStateProvider>();
        //     authStateProvider.AuthenticationStateChanged += AuthStateProvider_AuthenticationStateChanged;

            builder.UseCsla(c =>
                    {
                        c.DataPortal()
                .DefaultProxy(typeof(Csla.DataPortalClient.HttpProxy), "/api/dataportaltext/");
                    });

            await builder.Build().RunAsync();
        }
            private void AuthStateProvider_AuthenticationStateChanged(System.Threading.Tasks.Task<AuthenticationState> task)
             {
            var cslaPrincipal = new Csla.Security.CslaClaimsPrincipal(task.Result.User);
            ApplicationContext.User = cslaPrincipal;
    }
        
    }
}




