using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrdersAndProducts.Models
{
	public class ProductsViewModel : BaseViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}