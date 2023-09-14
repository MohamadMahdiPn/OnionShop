using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Entities.Store;
using OnionShop.DataLayer.Enums;

namespace OnionShop.DataLayer.Entities.Wallet
{
    public class SellerWallet : BaseEntity
    {
        #region properties

        public int SellerId { get; set; }

        public int Price { get; set; }

        public TransactionType TransactionType { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Description { get; set; }

        #endregion

        #region relations

        public Seller Seller { get; set; }

        #endregion
    }

   
}
