using System.Collections.Generic;
using System.Threading.Tasks;
using APPLICATION.Book.DTOS;
using APPLICATION.DTOS;

namespace APPLICATION.Book
{
    public interface IManageBookService
    {
        Task<int> Create(BookCreateRequest request);
        Task<int>  Update(BookEditRequest request);
        Task<int>  Delete(int bookID);
        Task<List<BookViewModel>> GetAll();
        Task<PageViewModel<BookViewModel>> GetAllPaging(GetBookPagingRequest request);
    }
}