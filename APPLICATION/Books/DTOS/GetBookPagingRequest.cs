using System.Collections.Generic;
using APPLICATION.DTOS;

namespace APPLICATION.Book.DTOS
{
    public class GetBookPagingRequest : PagingRequestBase
    {
        public int BookID { get; set; }
    }
}