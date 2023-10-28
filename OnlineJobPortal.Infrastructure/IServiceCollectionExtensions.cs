using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Identity;
using OnlineJobPortal.Infrastructure.Implementation;
using OnlineJobPortal.Infrastructure.Implementation.Repositories;
using System.Text;

namespace OnlineJobPortal.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddAuthentication(services, configuration);
            AddDbContext(services, configuration);
            AddRepositories(services);

            services.AddHttpContextAccessor();
        }

        private static void AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
                services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new
                    TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = configuration["JwtSettings:ValidAudience"],
                        ValidIssuer = configuration["JwtSettings:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                            configuration["JwtSettings:SecretKey"]))
                    };
                });
        }

        private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                    opt.UseSqlServer(configuration.GetConnectionString("ITJobsDB"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>()
                    .AddScoped<IAuthService, AuthService>()
                    .AddScoped<ICurrentUserService, CurrentUserSevice>()
                    .AddScoped<IUploadService, UploadService>();



            services
                .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddScoped<IAdminRepository, AdminRepository>()
                .AddScoped<IApplyRepository, ApplyRepository>()
                .AddScoped<IBussinessIndustryRepository, BussinessIndustryRepository>()
                .AddScoped<ICandidateRepository, CandidateRepository>()
                .AddScoped<ICandidateSkillRepository, CandidateSkillRepository>()
                .AddScoped<ICompanyImageRepository, CompanyImageRepository>()
                .AddScoped<ICompanyRepository, CompanyRepository>()
                .AddScoped<IEducationRepository, EducationRepository>()
                .AddScoped<IEmployerRepository, EmployerRepository>()
                .AddScoped<IExperienceRepository, ExperienceRepository>()
                .AddScoped<IForeignLanguageRepository, ForeignLanguageRepository>()
                .AddScoped<IJobFavoriteRepository, JobFavoriteRepository>()
                .AddScoped<IJobPostRepository, JobPostRepository>()
                .AddScoped<IJobTypeRepository, JobTypeRepository>()
                .AddScoped<IMessageRepository, MessageRepository>()
                .AddScoped<IResumeRepository, ResumeRepository>()
                .AddScoped<IRequirementSkillRepository, RequirementSkillRepository>()
                .AddScoped<ISkillRepository, SkillRepository>()
                .AddScoped<ICurrentUserService, CurrentUserSevice>()
                .AddScoped<IDistrictRepository, DistrictRepository>()
                .AddScoped<IProvinceRepository, ProvinceRepository>();
        }
    }
}
