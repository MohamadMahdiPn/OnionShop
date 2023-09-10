using Microsoft.EntityFrameworkCore;
using OnionShop.DataLayer.Entities.Account;

namespace OnionShop.DataLayer.Context;

public class MarketPlaceDbContext:DbContext
{
    public MarketPlaceDbContext()
    {
        
    }


    #region dbSets

    public DbSet<ApplicationUser> Users { get; set; }

    #endregion
}