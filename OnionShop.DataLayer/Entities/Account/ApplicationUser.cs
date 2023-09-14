using OnionShop.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionShop.DataLayer.Entities.Account
{
    public class ApplicationUser: BaseEntity
    {
        [Display(Name="ایمیل")]
        [Required(ErrorMessage = "اجباری است")]
        [MaxLength(50 , ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "اجباری است")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        
        public string EmailActiveCode { get; set; }
        public bool IsEmailActive { get; set; }
        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "اجباری است")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        [DataType(DataType.EmailAddress)]
        public string Phone { get; set; }
        public string PhoneActiveCode { get; set; }
        public bool IsPhoneActive { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public bool IsBlocked { get; set; }
    }
}
