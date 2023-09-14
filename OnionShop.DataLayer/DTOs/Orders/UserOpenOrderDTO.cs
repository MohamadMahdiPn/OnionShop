﻿using System.Collections.Generic;
using System.Linq;

namespace OnionShop.DataLayer.DTOs.Orders
{
    public class UserOpenOrderDTO
    {
        public long UserId { get; set; }

        public string Description { get; set; }

        public List<UserOpenOrderDetailItemDTO> Details { get; set; }

        public int GetTotalPrice()
        {
            return Details.Sum(s => (s.ProductPrice + s.ProductColorPrice) * s.Count);
        }

        public int GetTotalDiscounts()
        {
            return Details.Sum(s => s.GetOrderDetailWithDiscountPriceAmount());
        }
    }
}
