namespace Services.DTOs
{
	public class OrderDetailInfo
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }

		public OrderInfo Order { get; set; }
		public ProductInfo Product { get; set; }
	}
}
