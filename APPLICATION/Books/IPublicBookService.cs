using System.Collections.Generic;
using APPLICATION.Book.DTOS;
using APPLICATION.DTOS;

namespace APPLICATION.Book
{
    public interface IPublicBookService
    {
        PageViewModel<BookViewModel> GetAllBook(GetBookPagingRequest request);
    }
}