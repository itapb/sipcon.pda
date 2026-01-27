using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Sipcon.Mobile.WebApp;
using Sipcon.Mobile.WebApp.Helper;
using Sipcon.Mobile.WebApp.Repository.Auth;
using Sipcon.Mobile.WebApp.Services;
using System.Globalization;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

var backEndUrl = "";
var env = builder.Configuration.GetValue<string>("Environment")!;
//backEndUrl = builder.Configuration.GetValue<string>($"BackEndUrl{env.Trim("PROD")}")!;
if (env == "DEV")
{
    backEndUrl = builder.Configuration.GetValue<string>("BackEndUrlDEV")!;
}
if (env == "QA")
{
    backEndUrl = builder.Configuration.GetValue<string>("BackEndUrlQA")!;
}
if (env == "PROD")
{
    backEndUrl = builder.Configuration.GetValue<string>("BackEndUrl")!;
}


builder.Services.AddHttpClient("ServerAPI", client => client.BaseAddress = new Uri(backEndUrl));
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ServerAPI"));

builder.Services.AddMudServices();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddTransient<ISessionStorageService, SessionStorageRepository>();
builder.Services.AddScoped<UserSession>();
builder.Services.AddScoped<AuthenticationProviderJWT>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT>());
builder.Services.AddScoped<IAuthorizeService, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT>());

await builder.Build().RunAsync();
