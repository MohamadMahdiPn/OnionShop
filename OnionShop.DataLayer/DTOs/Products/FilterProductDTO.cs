
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnionShop.DataLayer.DTOs.Paging;
using OnionShop.DataLayer.Entities.Products;

namespace OnionShop.DataLayer.DTOs.Products
{
    public class FilterProductDTO : BasePaging
    {
        #region constructor

        public FilterProductDTO()
        {
            OrderBy = FilterProductOrderBy.CreateData_Des;
        }

        #endregion

        #region properteis

        public string ProductTitle { get; set; }

        public string Category { get; set; }

        public long? SellerId { get; set; }

        public int FilterMinPrice { get; set; }

        public int FilterMaxPrice { get; set; }

        public int SelectedMinPrice { get; set; }

        public int SelectedMaxPrice { get; set; }

        public int PriceStep { get; set; } = 100000;

        public FilterProductState FilterProductState { get; set; }

        public FilterProductOrderBy OrderBy { get; set; }

        public List<Product> Products { get; set; }

        public List<long> SelectedProductCategories { get; set; }

        #endregion

        #region methods

        public FilterProductDTO SetProducts(List<Product> products)
        {
            this.Products = products;
            return this;
        }

        public FilterProductDTO SetPaging(BasePaging paging)
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
