using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QuickPassword;
using QuickPassword.Services;
using QuickPassword.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPasswordGeneratorService, PasswordGeneratorService>();

builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
