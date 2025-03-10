using BooksService.Database;
using BooksService.IRepository;
using BooksService.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;

namespace BooksService.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BooksData>> GetAllBooksAsync()
        {
            return await _context.RasBooks.ToListAsync();
        }

        public async Task<BooksData?> GetBookByIdAsync(int id)
        {
            return await _context.RasBooks.FindAsync(id);
        }

        public async Task AddBookAsync(BooksData book)
        {
            await _context.RasBooks.AddAsync(book);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
