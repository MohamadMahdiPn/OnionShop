using OnionShop.DataLayer.Entities.Common;

namespace OnionShop.DataLayer.Repository.interfaces;

public interface IGenericRepository<TEntity>: IAsyncDisposable where TEntity : BaseEntity 
{
    Task<bool> AddEntity(TEntity entity);
    Task<bool> UpdateEntity(TEntity entity);
    Task<TEntity?> GetEntity(int id);
    Task<bool> DeleteEntity(int id);
    Task<bool> DeleteEntity(TEntity entity);
    IQueryable<TEntity> GetQuery();
}