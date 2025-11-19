using Blazored.LocalStorage;
using ETMS2026CORE10WA;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection; // Required for AddHttpClient()

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

// Use the standard IHttpClientFactory registration:
builder.Services.AddHttpClient();

// REMOVE the old, manually created HttpClient:
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); 

await builder.Build().RunAsync();