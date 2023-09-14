using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.DTOs.Discount
{
    public class CreateProductDiscountDto
    {
        public long ProductId { get; set; }

        [Range(0, 100)]
        public int Percentage { get; set; }

        public string ExpireDate { get; set; }

        public int DiscountNumber { get; set; }
    }

  
}
