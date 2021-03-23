using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPLICATION.Book.DTOS;
using APPLICATION.DTOS;
using DATA.EF;
using Microsoft.EntityFrameworkCore;

namespace APPLICATION.Book
{
    public class PublicBookService : IPublicBookService
    {
        private readonly BaseContext _context;
        public PublicBookService(BaseContext context)
        {
            _context = context;
        }

        public async Task<List<BookViewModel>> GetAll()
        {
            var query = _context.Books;

            var result = await query.Select(b => new BookViewModel()
            {
                ID = b.ID,
                Title = b.Title,
                Author = b.Author,
                Language = b.Language
            }).ToListAsync();

            return result;
        }

        public async Task<PageViewModel<BookViewModel>> GetAllBookByID(GetBookPagingRequest request)
        {
            var query = _context.Books.Where(x => x.Title.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                            .Take(request.PageSize)
                            .Select(b => new BookViewModel()
                            {
                                ID = b.ID,
                                Title = b.Title,
                                Author = b.Author
                            }).ToListAsync();
            var pageResult = new PageViewModel<BookViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pageResult;
        }
    }
}