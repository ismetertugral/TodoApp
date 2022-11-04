using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coldplayz.TodoAppNTier.Business.Interfaces;
using coldplayz.TodoAppNTier.DataAccess.UnitofWork;
using coldplayz.TodoAppNTier.Dtos.WorkDtos;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;
        public WorkService(IUow uow)
        {
            _uow = uow;
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(new() { Definition = dto.Definition, Id = dto.Id, IsCompleted = dto.IsCompleted });
            await _uow.SaveChanges();
        }

        public async Task Remove(object id)
        {
            var deletedWork = await _uow.GetRepository<Work>().GetById(id);
            _uow.GetRepository<Work>().Remove(deletedWork);
            await _uow.SaveChanges();
        }

        public async Task<WorkListDto> GetById(object id)
        {
            var data = await _uow.GetRepository<Work>().GetById(id);
            return new() { Definition = data.Definition, Id = data.Id, IsCompleted = data.IsCompleted };
        }

        public async Task Create(WorkCreateDto dto)
        {
            await _uow.GetRepository<Work>().Create(new() { Definition = dto.Definition, IsCompleted = dto.IsCompleted });
            await _uow.SaveChanges();
        }
        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();

            var mappedList = new List<WorkListDto>();
            if (list != null && list.Count > 0)
            {
                foreach (var work in list)
                {
                    mappedList.Add(new()
                    {
                        Definition = work.Definition,
                        Id = work.Id,
                        IsCompleted = work.IsCompleted
                    });
                }
            }
            return mappedList;
        }
    }
}