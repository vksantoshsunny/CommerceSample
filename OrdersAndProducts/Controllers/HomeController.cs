using OrdersAndProducts.Models;
using Services;
using System.Web.Mvc;

namespace OrdersAndProducts.Controllers
{
	public class HomeController : BaseController
    {
		protected IService _service;

		public HomeController(IService service)
		{
			_service = service;
		}
        // GET: Home
        public ActionResult Index()
        {
			ProductsViewModel productsViewModel = new ProductsViewModel();
			_service.GetAllProducts();
            return View();
        }
    }
}