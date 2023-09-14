

using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.Entities.Products;
public class ProductSelectedCategory : BaseEntity
    {
        #region properties

        public int? ProductId { get; set; }

        public int? ProductCategoryId { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        public ProductCategory ProductCategory { get; set; }

        #endregion
    }
