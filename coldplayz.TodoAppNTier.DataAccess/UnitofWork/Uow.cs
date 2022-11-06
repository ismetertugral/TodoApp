using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coldplayz.TodoAppNTier.DataAccess.Interfaces;
using coldplayz.TodoAppNTier.DataAccess.Contexts;
using coldplayz.TodoAppNTier.DataAccess.Repositories;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.DataAccess.UnitofWork
{
    public class Uow : IUow
    {
        private readonly TodoContext _context;

        public Uow(TodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T: BaseEntity
        {
            return new Repository<T>(_context);
        }
        public async Task SaveChanges(){
            await _context.SaveChangesAsync();
        }
    }
}