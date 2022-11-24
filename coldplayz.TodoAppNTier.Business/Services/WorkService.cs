using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using coldplayz.TodoAppNTier.Business.Interfaces;
using coldplayz.TodoAppNTier.DataAccess.UnitofWork;
using coldplayz.TodoAppNTier.Dtos.WorkDtos;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public WorkService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(_mapper.Map<Work>(dto));
            await _uow.SaveChanges();
        }

        public async Task Remove(int id)
        {
            _uow.GetRepository<Work>().Remove(id);
            await _uow.SaveChanges();
        }

        public async Task<WorkListDto> GetById(int id)
        {
            return _mapper.Map<WorkListDto>(await _uow.GetRepository<Work>().GetByFilter(x=>x.Id==id));
        }

        public async Task Create(WorkCreateDto dto)
        {
            await _uow.GetRepository<Work>().Create(_mapper.Map<Work>(dto));
            await _uow.SaveChanges();
        }
        public async Task<List<WorkListDto>> GetAll()
        {
            return _mapper.Map<List<WorkListDto>>(await _uow.GetRepository<Work>().GetAll());
        }
    }
}