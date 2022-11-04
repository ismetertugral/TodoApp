using coldplayz.TodoAppNTier.DataAccess.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using coldplayz.TodoAppNTier.DataAccess.UnitofWork;
using coldplayz.TodoAppNTier.Business.Interfaces;
using coldplayz.TodoAppNTier.Business.Services;

namespace coldplayz.TodoAppNTier.Business.DependencyResolvers.Microsoft{
    public static class DependencyExtension{
        public static void AddDependencies(this IServiceCollection services){
            services.AddDbContext<TodoContext>(opt=>{
                opt.UseSqlServer("server=.\\sqlexpress; database=TodoDb; integrated security=true;");/*localhost\\sqlexpress*/
            });

            services.AddScoped<IUow,Uow>();
            services.AddScoped<IWorkService,WorkService>();
        }
    }
}