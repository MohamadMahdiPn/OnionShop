using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum TicketSection
{
    [Display(Name = "پشتیبانی")]
    Support,
    [Display(Name = "فنی")]
    Technical,
    [Display(Name = "آموزشی")]
    Academic
}