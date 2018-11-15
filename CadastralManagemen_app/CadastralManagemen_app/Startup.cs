using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadastralManagemen_app.Startup))]
namespace CadastralManagemen_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
