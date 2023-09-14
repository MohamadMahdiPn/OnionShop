using Microsoft.EntityFrameworkCore;
using OnionShop.DataLayer.Context;
using OnionShop.DataLayer.Entities.Common;
using OnionShop.DataLayer.Repository.interfaces;

namespace OnionShop.DataLayer.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    #region Constructor

    private readonly OnionShopDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(OnionShopDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    #endregion


    #region Create

    public async Task<bool> AddEntity(TEntity entity)
    {
        entity.CreatedDateTime = DateTime.Now;
        await _dbSet.AddAsync(entity);
        return await _context.SaveChangesAsync() > 0;
    }


    #endregion

    #region Get

    public async Task<TEntity?> GetEntity(int id)
    {
        return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
    }


    #endregion


    #region Update

    public async Task<bool> UpdateEntity(TEntity entity)
    {
        entity.ModifiedDateTime = DateTime.Now;
        _dbSet.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    #endregion

    #region Dispose

    public async ValueTask DisposeAsync()
    {
        if (_context != null)
        {
            await _context.DisposeAsync();
        }

    }

    #endregion

    #region Delete

    public async Task<bool> DeleteEntity(int id)
    {
        var entity = await GetEntity(id);
        entity.IsDeleted = true;
        return await UpdateEntity(entity);
    }

    public async Task<bool> DeleteEntity(TEntity entity)
    {
        entity.IsDeleted = true;
        return await UpdateEntity(entity);
    }

    public IQueryable<TEntity> GetQuery()
    {
        return _dbSet.AsQueryable();
    }

    #endregion

}