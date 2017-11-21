using Data;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
	public static class Mapping
	{
		public static ProductInfo ToProductInfoMap(this Product product)
		{
			return new ProductInfo()
			{
			Id = product.Id,
			Name = product.Name,
			Description = product.Description
			};
		}

	}
}
