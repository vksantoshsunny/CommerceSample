using Data;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
	public static class MappingHelper
	{
		public static ProductInfo ToProductInfoMap(Product product)
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
