using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Dto
{
    public class PaginateDto
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}