using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services
{
	public interface IService : IDisposable
	{
		void AddProduct(ProductInfo product);
		void UpdateProduct(ProductInfo product);
		void DeleteProduct(int id);
		List<ProductInfo> GetAllProducts();
		ProductInfo GetProduct(int productId);
	}
}
