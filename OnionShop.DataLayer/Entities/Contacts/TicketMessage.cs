using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.Entities.Account;
using OnionShop.DataLayer.Entities.Common;

namespace OnionShop.DataLayer.Entities.Contacts;

public class TicketMessage : BaseEntity
{
    #region properties





    [Display(Name = "متن پیام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string Text { get; set; }

    #endregion

    #region relations
    public int? TicketId { get; set; }
    public Ticket Ticket { get; set; }

    public int? SenderId { get; set; }
    public ApplicationUser Sender { get; set; }

    #endregion
}