using System.Threading.Tasks;
using coldplayz.TodoAppNTier.DataAccess.Interfaces;

namespace coldplayz.TodoAppNTier.DataAccess.UnitofWork{
    public interface IUow{
        IRepository<T> GetRepository<T>() where T: class,new();
        Task SaveChanges();
    }
}