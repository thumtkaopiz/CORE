using System.Collections.Generic;

namespace APPLICATION.DTOS
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}