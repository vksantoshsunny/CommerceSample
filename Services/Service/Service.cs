using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.Mapping;
using Services.DTOs;
using Services.Interfaces;
using Services.UOW;

namespace Services.Service
{
	public class Service : IService
	{
		private readonly IUnitOfWork _unitOfWork;

		public Service()
		{
			this._unitOfWork = new UnitOfWork();
		}

		void IService.AddProduct(ProductInfo product)
		{
			throw new NotImplementedException();
		}

		void IService.DeleteProduct(int id)
		{
			throw new NotImplementedException();
		}

		void IDisposable.Dispose()
		{
			throw new NotImplementedException();
		}

		List<ProductInfo> IService.GetAllProducts()
		{
			List<ProductInfo> products = new List<ProductInfo>();
			foreach(var product in _unitOfWork.ProductRepository.GetAll())
			{
				ProductInfo productInfo = new ProductInfo();
				productInfo = product.ToProductInfoMap();
				products.Add(productInfo);
			}
			return products;
		}

		ProductInfo IService.GetProduct(int productId)
		{
			throw new NotImplementedException();
		}

		void IService.UpdateProduct(ProductInfo product)
		{
			throw new NotImplementedException();
		}
	}
}
