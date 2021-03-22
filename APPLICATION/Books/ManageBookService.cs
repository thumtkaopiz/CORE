using System.Collections.Generic;
using System.Threading.Tasks;
using APPLICATION.Book.DTOS;
using APPLICATION.DTOS;
using DATA.EF;

namespace APPLICATION.Book
{
    public class ManageBookService : IManageBookService
    {
        private readonly BaseContext _context;
        public ManageBookService(BaseContext context)
        {
            _context = context;
        }
        public async Task<int> Create(BookCreateRequest request)
        {
            var book = new DATA.Entities.Book()
            {
                Title = request.Title,
                Author = request.Author,
                Language = request.Language,
                Publisher = new List<DATA.Entities.Publisher>()
                {
                    new DATA.Entities.Publisher(){
                        Name = request.PublisherName
                    }
                }
            };
            _context.Books.Add(book);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int bookID)
        {
            var book = await _context.Books.FindAsync(bookID);
            _context.Books.Remove(book);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<BookViewModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<PageViewModel<BookViewModel>> GetAllPaging(GetBookPagingRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> Update(BookEditRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}