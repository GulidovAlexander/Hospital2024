using BlazorClient.Models.Entity;

using Microsoft.EntityFrameworkCore;

namespace BlazorClient
{
    public class Program
    {
        public static ApplicationDBContext DBContext { get; private set; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var conecctionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(conecctionString)
            );




            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            var app = builder.Build();

            var serviceScope = app.Services.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;
            DBContext = serviceProvider.GetRequiredService<ApplicationDBContext>();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
