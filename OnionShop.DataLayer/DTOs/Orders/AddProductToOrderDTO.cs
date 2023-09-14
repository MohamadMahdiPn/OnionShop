
namespace OnionShop.DataLayer.DTOs.Orders
{
    public class AddProductToOrderDTO
    {
        public long ProductId { get; set; }
        public long? ProductColorId { get; set; }
        public int Count { get; set; }
    }
}
