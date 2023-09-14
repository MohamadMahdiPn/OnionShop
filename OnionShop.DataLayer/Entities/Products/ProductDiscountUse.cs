
using OnionShop.DataLayer.Entities.Account;
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.Entities.Products;

    public class ProductDiscountUse : BaseEntity
    {
        #region properties

        public int ProductDiscountId { get; set; }

        public int UserId { get; set; }

        #endregion

        #region relations

        public ApplicationUser User { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

        #endregion
    }

