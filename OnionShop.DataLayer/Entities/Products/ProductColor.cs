using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.ProductOrders;

namespace OnionShop.DataLayer.Entities.Products;

    public class ProductColor : BaseEntity
    {
        #region properties

        public int? ProductId { get; set; }

        [Display(Name = "رنگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ColorName { get; set; }

        [Display(Name = "کد رنگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ColorCode { get; set; }

        public int Price { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        #endregion
    }

