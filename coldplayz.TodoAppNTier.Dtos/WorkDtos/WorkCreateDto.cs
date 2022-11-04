using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coldplayz.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto
    {
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}