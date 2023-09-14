using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum TicketPriority
{
    [Display(Name = "کم")]
    Low,
    [Display(Name = "متوسط")]
    Medium,
    [Display(Name = "زیاد")]
    High
}