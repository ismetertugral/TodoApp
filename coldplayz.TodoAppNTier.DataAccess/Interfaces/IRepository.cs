using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;
using System.Linq;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.DataAccess.Interfaces{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(object id);
        Task<T> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false);
        Task Create(T entity);
        void Update(T entity);
        void Remove(T entity);  
        IQueryable<T> GetQuery();
    }
}