﻿using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.DTOs.Products
{
    public class CreateProductColorDTO
    {
        [Display(Name = "رنگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ColorName { get; set; }

        [Display(Name = "کد رنگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ColorCode { get; set; }

        public int Price { get; set; }
    }
}
