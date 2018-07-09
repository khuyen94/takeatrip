using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TakeATrip.Web.Models;
using TakeATrip.Web.Services;
using Repositoy.Pattern.UnitOfWork;
using Repository.Pattern.EfCore;
using TakeATrip.Entities.Core;
using TakeATrip.Entities.IdentityDB;
using TakeATrip.Services.Common;
using TakeATrip.Services.Models;
using Microsoft.AspNetCore.Http;

namespace TakeATrip.Web
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
            //Add db context
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TakeATripConnection")));

            services.AddDbContext<TakeatripContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TakeATripConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //Add Authentication
            services.AddAuthentication()
            .AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            })
            .AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });

            // Add application services.          
            services.AddScoped<DbContext, TakeatripContext>();
            services.AddScoped<IUnitOfWorkAsync, UnitOfWork>();

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();

            app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

            //if (env.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error/{0}");
            //    //app.UseBrowserLink();
            //    //app.UseDeveloperExceptionPage();
            //    //app.UseDatabaseErrorPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error/{0}");
            //}

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
