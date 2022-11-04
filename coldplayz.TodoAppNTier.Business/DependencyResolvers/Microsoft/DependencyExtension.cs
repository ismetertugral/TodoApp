using coldplayz.TodoAppNTier.DataAccess.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using coldplayz.TodoAppNTier.DataAccess.UnitofWork;
using coldplayz.TodoAppNTier.Business.Interfaces;
using coldplayz.TodoAppNTier.Business.Services;
using Microsoft.Extensions.Logging;

namespace coldplayz.TodoAppNTier.Business.DependencyResolvers.Microsoft{
    public static class DependencyExtension{
        public static void AddDependencies(this IServiceCollection services){
            services.AddDbContext<TodoContext>(opt=>{
                opt.UseSqlServer("server=.\\sqlexpress; database=TodoDb; integrated security=true;");/*localhost\\sqlexpress*/
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });

            services.AddScoped<IUow,Uow>();
            services.AddScoped<IWorkService,WorkService>();
        }
    }
}