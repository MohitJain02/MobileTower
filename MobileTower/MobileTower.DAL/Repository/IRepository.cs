using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MobileTower.DAL.Repository
{
    public interface IRepository<T>
    {
        T Add(T newItem);

        void Delete(T entity);

        T FindById(int id);

        Task<T> FindByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();


        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        Task<T> UpdateAsync(int id, T itemToUpdate);

    }
}
