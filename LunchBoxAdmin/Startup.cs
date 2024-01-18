using LunchBoxAdmin.Middleware;
using LunchBox.Shared;
using LunchBoxAdmin.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace LunchBoxAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /*
         * 1. Model: create Model eller ViewModels i Model eller ViewModels folder
           2. Repository pattern med interface or Class i Model folder
           3. Controller: og inject Repository eller new object i Controller
           3. Controller: Evt Lav model og pass it to View
           4. Lav View
        */

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();

            services.AddDbContext<LbDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<LbDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductExtraItemsRepository, ProductExtraItemsRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.ConfigureApplicationCookie(config =>
            {
                /* config.LoginPath =  "login"; Don't need "Account/login" is default */
                config.AccessDeniedPath = new PathString("/Account/AccessDenied");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error"); // 500 Internal Server Error. Global Exceptions
                app.UseStatusCodePagesWithReExecute("/Error/{0}");  // 404 error. Middelware to 404 error, etc the page not found. Uses only in Production ENVIRONMENT
            }
             app.UseSession();
             //app.UseMiddleware<AuthenticationMiddleware>(); // previus session authentication

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
