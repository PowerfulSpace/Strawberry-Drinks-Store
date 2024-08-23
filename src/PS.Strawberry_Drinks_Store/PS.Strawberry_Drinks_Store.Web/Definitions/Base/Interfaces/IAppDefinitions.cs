﻿namespace PS.Strawberry_Drinks_Store.Web.Definitions.Base.Interfaces
{
    public interface IAppDefinitions
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration);
        public void ConfigureApplication(WebApplication app, IWebHostEnvironment environment);
    }
}
