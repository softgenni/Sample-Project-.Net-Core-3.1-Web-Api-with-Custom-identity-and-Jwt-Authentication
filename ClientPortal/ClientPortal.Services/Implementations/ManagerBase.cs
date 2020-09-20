using AutoMapper;
using ClientPortal.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientPortal.Services
{
    public abstract class ManagerBase<TModel, TEntity> : IManagerBase<TModel>
       where TModel : class
       where TEntity : class
    {
        protected readonly IMapper Mapper;
        protected readonly IGenericRepository<TEntity> Repository;
        public ManagerBase(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            this.Repository = repository;
            this.Mapper = mapper;
        }
        public virtual async Task<TModel> AddAsync(TModel model)
        {
            var result = await Repository.AddAsync(this.Mapper.Map<TEntity>(model));
            return this.Mapper.Map<TModel>(result);
        }

        public virtual async Task DeleteAsync(TModel model)
        {
            await Repository.DeleteAsync(this.Mapper.Map<TModel>(model));
        }

        public virtual async Task DeleteAsync(object id)
        {
            await Repository.DeleteAsync(id);
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var result = await Repository.GetAllAsync();
            return this.Mapper.Map<IEnumerable<TModel>>(result);
        }

        public virtual async Task<TModel> GetByIdAsync(object id)
        {
            var result = await Repository.GetByIdAsync(id);
            return this.Mapper.Map<TModel>(result);
        }
        public virtual async Task<TModel> updateAsync(TModel model, object id)
        {
            var result = await Repository.UpdateAsyc(id, this.Mapper.Map<TEntity>(model));
            return this.Mapper.Map<TModel>(result);
        }
    }
}
