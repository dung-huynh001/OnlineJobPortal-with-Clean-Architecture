using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineJobPortal.Application;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Identity;
using OnlineJobPortal.Presentation;
using OnlineJobPortal.Presentation.SignalR;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add configuration of Application Proj
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPresentation(builder.Configuration);
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddTransient<ITJobsHub>();

builder.Services.AddControllersWithViews();
builder.Services.AddMvc()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddSignalR();

builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.ConfigureApplicationCookie(options => {
    options.AccessDeniedPath = $"/Home/AccessDenied";
    options.LoginPath = $"/login";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapHub<ITJobsHub>("/chat");

app.MapAreaControllerRoute(
    name: "AdminArea",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapAreaControllerRoute(
    name: "EmployerArea",
    areaName: "Employer",
    pattern: "Employer/{controller=Home}/{action=Index}/{id?}"
);


app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
