﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DTOs;
using Services.Interfaces;

namespace Services.Service
{
	public class Service : IService
	{
		private readonly IUnitOfWork _unitOfWork;

		public Service(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
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
			throw new NotImplementedException();
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