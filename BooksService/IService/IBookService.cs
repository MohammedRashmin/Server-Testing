using BooksService.NewFolder;

namespace BooksService.IService
{
    public interface IBookService
    {
        Task<IEnumerable<BooksData>> GetAllBooksAsync();
        Task<BooksData?> GetBookByIdAsync(int id);
        Task AddBookAsync(BooksData book);
    }
}
