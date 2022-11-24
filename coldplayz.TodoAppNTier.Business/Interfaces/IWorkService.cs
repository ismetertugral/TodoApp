using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coldplayz.TodoAppNTier.Dtos.WorkDtos;

namespace coldplayz.TodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<List<WorkListDto>> GetAll();

        Task Create(WorkCreateDto dto);

        Task<WorkListDto> GetById(int id);

        Task Remove(int id);

        Task Update(WorkUpdateDto dto);
    }
}