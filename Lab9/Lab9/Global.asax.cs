using System.Web.Http;

namespace Lab9
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // This registers Web API routes and configuration.
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
