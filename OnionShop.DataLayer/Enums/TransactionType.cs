using System.ComponentModel.DataAnnotations;

namespace OnionShop.DataLayer.Enums;

public enum TransactionType
{
    [Display(Name = "واریز")]
    Deposit,
    [Display(Name = "برداشت")]
    Withdrawal
}