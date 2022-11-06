using System.Threading.Tasks;
using coldplayz.TodoAppNTier.DataAccess.Interfaces;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.DataAccess.UnitofWork{
    public interface IUow{
        IRepository<T> GetRepository<T>() where T: BaseEntity;
        Task SaveChanges();
    }
}