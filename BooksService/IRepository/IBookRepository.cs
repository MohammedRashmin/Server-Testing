using BooksService.NewFolder;

namespace BooksService.IRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BooksData>> GetAllBooksAsync();
        Task<BooksData?> GetBookByIdAsync(int id);
        Task AddBookAsync(BooksData book);
        Task SaveChangesAsync();
    }
}
