using Microsoft.EntityFrameworkCore;
using ModelViewController.Context;
using ModelViewController.Repository;
using Volo.Abp.Data;

namespace ModelViewController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IHotelsRepository, HotelsRepository>();

            var connectionstring = builder.Configuration.GetConnectionString("BooknowDbContext");
            builder.Services.AddDbContext<BooknowDbContext>(options => options.UseSqlServer(connectionstring));


            //_ = builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

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