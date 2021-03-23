using System.Collections.Generic;
using System.Threading.Tasks;
using APPLICATION.Book.DTOS;
using APPLICATION.DTOS;

namespace APPLICATION.Book
{
    public interface IPublicBookService
    {
        Task<PageViewModel<BookViewModel>> GetAllBookByID(GetBookPagingRequest request);
        Task<List<BookViewModel>> GetAll();
    }
}