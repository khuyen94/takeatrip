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
using Repositoy.Pattern.UnitOfWork;
using Repository.Pattern.EfCore;
using TakeATrip.Entities.Core;
using TakeATrip.Entities.IdentityDB;
using TakeATrip.Services.Common;
using Microsoft.AspNetCore.Http;
using TakeATrip.Services.Core;
using AutoMapper;
using Service.Pattern;
using Repositoy.Pattern.Repositories;
using Microsoft.Extensions.Logging;

namespace TakeATrip.Web
{
    public partial class Startup
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

            AddDataServices(services);

            AddCommonServices(services);

            services.AddSingleton(Configuration);

            services.AddAutoMapper();

            services.AddLogging();

            services.AddMvc();
        }

        private void AddDataServices(IServiceCollection services)
        {
            // Add dbcontext services.          
            services.AddTransient<DbContext, TakeatripContext>();
            services.AddScoped<IUnitOfWorkAsync, UnitOfWork>();

            //add repositories 
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(Repository<>));

            //add services 
            services.AddTransient(typeof(IService<>), typeof(Service<>));
            services.AddTransient<ITourService, TourService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ICartService, CartService>();
        }

        private void AddCommonServices(IServiceCollection services)
        {
            services.AddTransient<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IServiceProvider service)
        {
            loggerFactory.AddFile("Logs/takeatrip-{Date}.txt");

            app.UseStatusCodePages();

            app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error/{0}");
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/{0}");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //init roles and supper admin
            CreateUserRoles(service).Wait();
        }
    }
}
