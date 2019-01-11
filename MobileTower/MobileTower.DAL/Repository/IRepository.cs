using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MobileTower.DAL.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> GetAll();


        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


        TEntity Add(TEntity newItem);

        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> newEntities);
        TEntity Remove(TEntity entity);

        IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entitiesToRemove);
    }
}
