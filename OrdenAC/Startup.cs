using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using OrdenAC.Models;
using OrdenAC.Services;
using SoapCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace OrdenAC
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
            services.AddControllersWithViews();

            services.TryAddSingleton<IOrdenService, WSOrdenService>();

            services.AddMvc();

            _ = services.AddDbContextPool<OrdenACDBContext>(options => options
                  // replace with your connection string
                  .UseMySql("Server=localhost;Database=ordenacdb;User=root;Password=mysqlAdmin;", mySqlOptions => mySqlOptions
                      // replace with your Server Version and Type
                      .ServerVersion(new Version(8, 0, 21), ServerType.MySql)
              ));

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=ConsultarOrden}/{id?}");
            });
            

            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Orden}/{action=Index}/{id?}");
            });
            */
            app.UseSoapEndpoint<IOrdenService>("/WSOrdenService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

        }
    }
}
