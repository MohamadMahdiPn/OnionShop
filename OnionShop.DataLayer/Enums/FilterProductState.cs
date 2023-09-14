using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum FilterProductState
{
    [Display(Name = "همه")]
    All,
    [Display(Name = "در حال بررسی")]
    UnderProgress,
    [Display(Name = "تایید شده")]
    Accepted,
    [Display(Name = "رد شده")]
    Rejected,
    [Display(Name = "فعال")]
    Active,
    [Display(Name = "غیر فعال")]
    NotActive
}