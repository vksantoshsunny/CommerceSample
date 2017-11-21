using System.Web.Mvc;

namespace OrdersAndProducts.Controllers
{
	public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}