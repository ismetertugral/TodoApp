using coldplayz.TodoAppNTier.DataAccess.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using coldplayz.TodoAppNTier.DataAccess.UnitofWork;
using coldplayz.TodoAppNTier.Business.Interfaces;
using coldplayz.TodoAppNTier.Business.Services;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System.Net;
using coldplayz.TodoAppNTier.Business.Mappings.AutoMapper;

namespace coldplayz.TodoAppNTier.Business.DependencyResolvers.Microsoft{
    public static class DependencyExtension{
        public static void AddDependencies(this IServiceCollection services){
            services.AddDbContext<TodoContext>(opt=>{
                opt.UseSqlServer("server=.\\sqlexpress; database=TodoDb; integrated security=true;");/*localhost\\sqlexpress*/
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });

            var configuration = new MapperConfiguration(opt => {
                opt.AddProfile(new WorkProfile());
            });
            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IUow,Uow>();
            services.AddScoped<IWorkService,WorkService>();
        }
    }
}