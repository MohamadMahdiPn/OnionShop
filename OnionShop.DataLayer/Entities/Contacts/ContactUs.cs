using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.Entities.Account;
using OnionShop.DataLayer.Entities.Common;

namespace OnionShop.DataLayer.Entities.Contacts;

public class ContactUs:BaseEntity
{
    #region properties

    public int? UserId { get; set; }

    [Display(Name = "IP کاربر")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string UserIp { get; set; }

    [Display(Name = "ایمیل")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Email { get; set; }

    [Display(Name = "نام و نام خانوادگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string FullName { get; set; }

    [Display(Name = "عنوان")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Subject { get; set; }

    [Display(Name = "متن پیام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string Text { get; set; }

    #endregion

    #region relations

    public ApplicationUser User { get; set; }

    #endregion
}