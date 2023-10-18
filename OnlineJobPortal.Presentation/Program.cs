using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineJobPortal.Application;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Identity;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add configuration of Application Proj
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();

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

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
