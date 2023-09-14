using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum TicketState
{
    [Display(Name = "در حال بررسی")]
    UnderProgress,
    [Display(Name = "پاسخ داده شده")]
    Answered,
    [Display(Name = "بسته شده")]
    Closed
}