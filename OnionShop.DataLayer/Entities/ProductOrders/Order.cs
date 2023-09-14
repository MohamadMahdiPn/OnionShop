using OnionShop.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Entities.ProductOrders;

public class Order : BaseEntity
{
    #region properties

    public int UserId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public bool IsPaid { get; set; }

    [Display(Name = "کد پیگیری")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string TracingCode { get; set; }

    [Display(Name = "کد پیگیری")]
    public string Description { get; set; }

    #endregion

    #region relations

    public ICollection<OrderDetail> OrderDetails { get; set; }

    #endregion
}