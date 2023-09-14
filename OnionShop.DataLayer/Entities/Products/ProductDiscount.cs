using System.ComponentModel.DataAnnotations;

using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.Entities.Products;
public class ProductDiscount : BaseEntity
    {
        #region properties

        public int? ProductId { get; set; }

        [Range(0, 100)]
        public int Percentage { get; set; }

        public DateTime ExpireDate { get; set; }

        public int DiscountNumber { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        public ICollection<ProductDiscountUse> ProductDiscountUses { get; set; }

        #endregion
    }

