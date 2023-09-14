using System.ComponentModel.DataAnnotations;

using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.Entities.Products;
public class ProductFeature : BaseEntity
{
    #region properties

    public int? ProductId { get; set; }

    [Display(Name = "عنوان ویژگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string FeatureTitle { get; set; }

    [Display(Name = "مقدار ویژگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string FeatureValue { get; set; }

    #endregion

    #region relations

    public Product Product { get; set; }

    #endregion
}

