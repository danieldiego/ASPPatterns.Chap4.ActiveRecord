using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPPatterns.Chap4.ActiveRecord.UI.MVC.Startup))]
namespace ASPPatterns.Chap4.ActiveRecord.UI.MVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
