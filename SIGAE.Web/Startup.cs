﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Helpers;
using System.Text;

namespace SIGAE.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("DesarrolloLocal")));

            services.AddTransient<DatosIniciales>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IUserHelper, UserHelper>();
            services.AddScoped<IPersonaHelper, PersonaHelper>();
            services.AddScoped<ITiposGastoHelper, TiposGastoHelper>();
            services.AddScoped<IGastosHelper, GastoHelper>();
            services.AddScoped<IGiraHelper, GiraHelper>();
            services.AddScoped<ILocalidadHelper, LocalidadHelper>();
            services.AddScoped<ITipoIdentificacionHelper, TipoIdentificacionHelper>();
            services.AddScoped<IIdentificacionHelper, IdentificacionHelper>();
            services.AddScoped<IGeneroHelper, GeneroHelper>();

            services.AddDefaultIdentity<User>(cfg =>
           {
               cfg.User.RequireUniqueEmail = true;
               cfg.Password.RequireDigit = false;
               cfg.Password.RequiredUniqueChars = 0;
               cfg.Password.RequireLowercase = false;
               cfg.Password.RequireNonAlphanumeric = false;
               cfg.Password.RequireUppercase = false;
           })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAuthentication()
                .AddCookie()
                .AddJwtBearer(cfg =>
               {
                   cfg.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidIssuer = this.Configuration["Tokens:Issuer"],
                       ValidAudience = this.Configuration["Tokens:Audience"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                           this.Configuration["Tokens:Key"]))
                   };
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
