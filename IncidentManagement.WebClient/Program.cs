using IncidentManagement.Shared.Services;
using IncidentManagement.WebClient;
using IncidentManagement.WebClient.Interfaces;
using IncidentManagement.WebClient.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Configure HttpClient with base address of WebApi
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7226/api/")
});

// Register frontend services
builder.Services.AddScoped<ApiClient>();
builder.Services.AddScoped<IncidentApiClientRepository>();
builder.Services.AddScoped<IncidentService>();
builder.Services.AddScoped<IIncidentStatusService, IncidentStatusService>();
builder.Services.AddScoped<IIncidentPriorityService, IncidentPriorityService>();
builder.Services.AddScoped<IIncidentRoleService, IncidentRoleService>();
builder.Services.AddScoped<ILookupCacheService, LookupCacheService>();
builder.Services.AddScoped<IIncidentPropertyService, IncidentPropertyService>();
builder.Services.AddScoped<IIncidentCategoryService, IncidentCategoryService>();

builder.Services.AddScoped(sp =>
{
    return new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7226/")
    };
});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<AuthState>();
builder.Services.AddSingleton<UserService>();

await builder.Build().RunAsync();
