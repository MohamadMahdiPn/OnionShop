using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum ProductAcceptanceState
{
    [Display(Name = "در حال بررسی")]
    UnderProgress,
    [Display(Name = "تایید شده")]
    Accepted,
    [Display(Name = "رد شده")]
    Rejected
}