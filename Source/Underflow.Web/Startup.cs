using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Underflow.Business;
using Underflow.data;

namespace Underflow.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<UnderflowContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<UnderflowService>();


            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddRoleManager<RoleManager<IdentityRole>>()
               .AddDefaultUI()
               .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //private async Task CreateUserRolesAsync(IServiceProvider services)
            //{
                ////create the role admin
                //var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                //var rolesManager = services.GetRequiredService<RoleManager<IdentityRole>>();


                //var roleExists = await rolesManager.RoleExistsAsync("admin");
                //if (!roleExists)
                //{
                //    await rolesManager.CreateAsync(new IdentityRole("admin"));
                //}

                //// lets give admin to a single user
                //var user = await userManager.FindByEmailAsync("j@j.com");
                //await userManager.AddToRoleAsync(user, "admin");








            }
    }
}
