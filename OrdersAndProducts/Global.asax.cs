using OrdersAndProducts.App_Start;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using OrdersAndProducts.Infrastructure;

namespace OrdersAndProducts
{
	public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DependencyResolver.SetResolver(new NinjectDependencyResolver());

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

        }
    }
}
