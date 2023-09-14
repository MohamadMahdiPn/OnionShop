﻿using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Enums;

namespace OnionShop.DataLayer.Entities.Site;
public class SiteBanner : BaseEntity
{
    #region properties

    [Display(Name = "نام تصویر")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string ImageName { get; set; }

    [Display(Name = "آدرس")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Url { get; set; }

    [Display(Name = "سایز ( کلاس های نمایشی )")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string ColSize { get; set; }

    public BannerPlacement BannerPlacement { get; set; }

    #endregion
}

