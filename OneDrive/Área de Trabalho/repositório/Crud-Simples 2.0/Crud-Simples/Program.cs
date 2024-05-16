using Crud_Simples.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud_Simples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Contexto>
   (options => options.UseMySql(
       "server=localhost;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;pwd=1234",
       Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql")));






            var app = builder.Build();

           
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
