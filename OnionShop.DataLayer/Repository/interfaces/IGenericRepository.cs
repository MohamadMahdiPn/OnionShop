using OnionShop.DataLayer.Entities.Common;

namespace OnionShop.DataLayer.Repository.interfaces;

public interface IGenericRepository<TEntity>: IAsyncDisposable where TEntity : BaseEntity 
{
    Task<bool> AddEntity(TEntity entity);
    Task<bool> UpdateEntity(TEntity entity);
    Task<TEntity?> GetEntity(long id);
    Task<bool> DeleteEntity(long id);
    Task<bool> DeleteEntity(TEntity entity);
    IQueryable<TEntity> GetQuery();
}