using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using coldplayz.TodoAppNTier.Dtos.WorkDtos;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.Business.Mappings.AutoMapper
{
    public class WorkProfile : Profile
    {
        public WorkProfile()
        {
            CreateMap<Work,WorkListDto>().ReverseMap();
            CreateMap<Work,WorkCreateDto>().ReverseMap();
            CreateMap<Work,WorkUpdateDto>().ReverseMap();
            CreateMap<WorkListDto,WorkUpdateDto>().ReverseMap();
        }
    }
}