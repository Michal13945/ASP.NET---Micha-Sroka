using DinkToPdf.Contracts;
using DinkToPdf;
using Labolatorium3_app.Middlewares;
using Labolatorium3_app.Models;
using Labolatorium3_app.Services;
using Microsoft.AspNetCore.Identity;
using System.Text;
using PdfSharp.Charting;
using Data;

namespace Labolatorium3_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
  
            builder.Services.AddTransient<IContactService, EFContactService>();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();
            builder.Services.AddRazorPages();                        
            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            builder.Services.AddTransient<IContactService, EFContactService>();
            builder.Services.AddMemoryCache();                        
            builder.Services.AddSession();


            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseMiddleware<LastVisitCookie>();
            app.UseAuthentication();                                 
            app.UseAuthorization();
            app.UseSession();                                      
            app.MapRazorPages();                                    

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}


    
