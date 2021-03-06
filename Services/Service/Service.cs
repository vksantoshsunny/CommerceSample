﻿using System;
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

		public Service(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		public void AddProduct(ProductInfo product)
		{
			throw new NotImplementedException();
		}

        public void DeleteProduct(int id)
		{
			throw new NotImplementedException();
		}

        public void Dispose()
		{
			throw new NotImplementedException();
		}

        public List<ProductInfo> GetAllProducts()
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

        public ProductInfo GetProduct(int productId)
		{
			throw new NotImplementedException();
		}

        public void UpdateProduct(ProductInfo product)
		{
			throw new NotImplementedException();
		}
	}
}
