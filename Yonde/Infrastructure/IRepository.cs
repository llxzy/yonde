using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> FindAsync(int id);
        Task Update(TEntity entity);
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}