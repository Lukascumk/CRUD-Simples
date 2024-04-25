using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy; 
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Threading.Tasks;



namespace Projeto_Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

            public IConfiguration Configuration { get; }

            //Este Metodo get called by the runtime. Use este metodo para adiconar servicos para container.

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllersWithViews();
            }



        //Este metodo get called by the ruintime. Use este metodo para configurar o HTTP requisito pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //o defalt HSTS valor é 30 dias. voce quer para checar o produto e senarios see https://aka.ms
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }



    }
}
