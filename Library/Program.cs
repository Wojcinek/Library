using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Areas.Identity.Data;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'LibraryContextConnection' not found.");

                                    builder.Services.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(connectionString));

                                                builder.Services.AddDefaultIdentity<LibraryUser>(options => options.SignIn.RequireConfirmedAccount = false)
                  .AddRoles<IdentityRole>()
                   .AddEntityFrameworkStores<LibraryContext>();



            // Add services to the container.
            builder.Services.AddControllersWithViews();
           

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
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}