using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortal.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        void Attach(TEntity entity);
        Task<int> CountAsync();
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(object id);
        Task<TEntity> UpdateAsyc(object id, TEntity entity);
        Task SaveAsync();
    }
}
