using MobileTower.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MobileTower.DAL.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private MobileTowerDbContext _dbContext;
        DbSet<T> _dbSet;

        public Repository(MobileTowerDbContext mobileTowerDbContext)
        {
            _dbContext = mobileTowerDbContext;
            _dbSet = _dbContext.Set<T>();
        }
  
        public T Add(T newItem)
        {
           return _dbSet.Add(newItem);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);

        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<T> UpdateAsync(int id, T itemToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}
