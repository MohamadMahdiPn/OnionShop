using Microsoft.EntityFrameworkCore;
using OnionShop.DataLayer.Entities.Account;
using OnionShop.DataLayer.Entities.Contacts;
using OnionShop.DataLayer.Entities.ProductOrders;
using OnionShop.DataLayer.Entities.Products;
using OnionShop.DataLayer.Entities.Site;
using OnionShop.DataLayer.Entities.Store;
using OnionShop.DataLayer.Entities.Wallet;

namespace OnionShop.DataLayer.Context;

public class OnionShopDbContext:DbContext
{
    #region Constructor

    public OnionShopDbContext(DbContextOptions<OnionShopDbContext> options):base(options)
    {
        
    }

    #endregion



    #region account

    public DbSet<ApplicationUser> Users { get; set; }

    #endregion

    #region site

    public DbSet<SiteSetting> SiteSettings { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<SiteBanner> SiteBanners { get; set; }

    #endregion

    #region contacts

    public DbSet<ContactUs> ContactUses { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketMessage> TicketMessages { get; set; }

    #endregion

    #region store

    public DbSet<Seller> Sellers { get; set; }

    #endregion

    #region products

    public DbSet<ProductCategory> ProductCategories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductGallery> ProductGalleries { get; set; }

    public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }

    public DbSet<ProductColor> ProductColors { get; set; }

    public DbSet<ProductFeature> ProductFeatures { get; set; }

    #endregion

    #region propduct discount

    public DbSet<ProductDiscount> ProductDiscounts { get; set; }

    public DbSet<ProductDiscountUse> ProductDiscountUses { get; set; }

    #endregion

    #region order

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    #endregion

    #region wallet

    public DbSet<SellerWallet> SellerWallets { get; set; }

    #endregion

    #region on model creating

    #endregion

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    foreach (var mutableForeignKey in modelBuilder.Model.GetEntityTypes().SelectMany(s=>s.GetForeignKeys()))
    //    {
    //        mutableForeignKey.DeleteBehavior = DeleteBehavior.Cascade;
    //    }
    //    base.OnModelCreating(modelBuilder);
    //}
}