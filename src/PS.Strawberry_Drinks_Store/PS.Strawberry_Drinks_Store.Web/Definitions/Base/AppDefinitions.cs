using PS.Strawberry_Drinks_Store.Web.Definitions.Base.Interfaces;

namespace PS.Strawberry_Drinks_Store.Web.Definitions.Base
{
    public abstract class AppDefinitions : IAppDefinitions
    {
        public virtual void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {
        }

        public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
