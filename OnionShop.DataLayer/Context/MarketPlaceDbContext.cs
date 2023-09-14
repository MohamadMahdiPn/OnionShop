using Microsoft.EntityFrameworkCore;
using OnionShop.DataLayer.Entities.Account;

namespace OnionShop.DataLayer.Context;

public class MarketPlaceDbContext:DbContext
{
    #region Constructor

    public MarketPlaceDbContext(DbContextOptions<MarketPlaceDbContext> options):base(options)
    {
        
    }

    #endregion
    


    #region dbSets

    public DbSet<ApplicationUser> Users { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var mutableForeignKey in modelBuilder.Model.GetEntityTypes().SelectMany(s=>s.GetForeignKeys()))
        {
            mutableForeignKey.DeleteBehavior = DeleteBehavior.Cascade;
        }
        base.OnModelCreating(modelBuilder);
    }
}