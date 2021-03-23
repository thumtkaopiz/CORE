using System.Collections.Generic;
using APPLICATION.DTOS;

namespace APPLICATION.Book.DTOS
{
    public class GetBookPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int BookID { get; set; }
    }
}