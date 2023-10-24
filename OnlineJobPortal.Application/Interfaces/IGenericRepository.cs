using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll { get; }
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity?> FindWeakEntityAsync(int pk1, int pk2);
        Task<List<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

    }
}
