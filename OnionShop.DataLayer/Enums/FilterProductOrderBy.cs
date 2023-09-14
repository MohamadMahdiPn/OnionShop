using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum FilterProductOrderBy
{
    [Display(Name = "تاریخ ( نزولی )")]
    CreateData_Des,
    [Display(Name = "تاریخ ( صعودی )")]
    CreateDate_Asc,
    [Display(Name = "قیمت ( نزولی )")]
    Price_Des,
    [Display(Name = "قیمت ( صعودی )")]
    Price_Asc,
}