namespace OnionShop.DataLayer.DTOs.Products
{
    public class EditProductDTO : CreateProductDTO
    {
        public long Id { get; set; }

        public string ImageName { get; set; }
    }

    
}
