using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coldplayz.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkListDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}