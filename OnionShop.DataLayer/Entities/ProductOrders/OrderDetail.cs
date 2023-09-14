
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.Entities.ProductOrders;

public class OrderDetail : BaseEntity
{
    #region properties

    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? ProductColorId { get; set; }

    public int Count { get; set; }

    public int ProductPrice { get; set; }

    public int ProductColorPrice { get; set; }

    #endregion

    #region relations

    public Order Order { get; set; }

    public Product Product { get; set; }

    public ProductColor ProductColor { get; set; }

    #endregion
}