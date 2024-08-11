using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PasswordStorageApp.BlazorClient;
using PasswordStorageApp.BlazorClient.Services;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/*builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://csharpjavadandahaiyi.tailwindcomponents.io/api/") });*/

    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5221/api/") });
builder.Services.AddRadzenComponents();

builder.Services.AddScoped<IToastService, RadzenToastManager>();

await builder.Build().RunAsync();












//using Microsoft.AspNetCore.Components.Web;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using PasswordStorageApp.BlazorClient;
//using PasswordStorageApp.BlazorClient.Services;
//using Radzen;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44335/api/") });

//builder.Services.AddRadzenComponents();

//builder.Services.AddScoped<IToastService, RadzenToastManager>();

//await builder.Build().RunAsync();

