using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tryzomato.Startup))]
namespace tryzomato
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
