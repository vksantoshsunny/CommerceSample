using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
	public class CustomerInfo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }

		public virtual IList<OrderInfo> Orders { get; set; }
	}
}
