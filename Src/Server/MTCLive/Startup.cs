using System.Net.Http.Formatting;
using System.Web.Http;
using Owin;

namespace MTCLive
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("defaultApi", "api/{controller}/{action}");

            config.Formatters.Clear();

            var formatter = new JsonMediaTypeFormatter();
            config.Formatters.Add(formatter);

            app.UseWebApi(config);
        }
    }
}