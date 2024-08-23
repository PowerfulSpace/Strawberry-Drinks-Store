﻿using PS.Strawberry_Drinks_Store.Web.Definitions.Base;

namespace PS.Strawberry_Drinks_Store.Web.Definitions.Common
{
    public class CommonDefinition : AppDefinitions
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();
        }

        public override void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
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
