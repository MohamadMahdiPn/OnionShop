using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.DTOs.Paging;

namespace OnionShop.DataLayer.DTOs.Seller
{
    public class FilterSellerDTO : BasePaging
    {
        #region properties

        public long? UserId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public FilterSellerState State { get; set; }

        public List<Entities.Store.Seller> Sellers { get; set; }

        #endregion


        #region methods

        public FilterSellerDTO SetSellers(List<Entities.Store.Seller> sellers)
        {
            this.Sellers = sellers;
            return this;
        }

        public FilterSellerDTO SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.AllEntitiesCount = paging.AllEntitiesCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.PageCount = paging.PageCount;
            return this;
        }

        #endregion
    }

  
}
