using Microsoft.EntityFrameworkCore;
using RentalsService.Database;
using RentalsService.Entities;
using RentalsService.IRepository;

namespace RentalsService.Repository
{
    public class RentalRepository : IRentalRepository
    {
        private readonly RentalDbContext _context;

        public RentalRepository(RentalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rental>> GetAllRentalsAsync()
        {
            return await _context.RentalsData.ToListAsync();
        }

        public async Task<Rental?> GetRentalByIdAsync(int id)
        {
            return await _context.RentalsData.FindAsync(id);
        }

        public async Task AddRentalAsync(Rental rental)
        {
            await _context.RentalsData.AddAsync(rental);
        }

        public async Task DeleteRentalAsync(int id)
        {
            var rental = await _context.RentalsData.FindAsync(id);
            if (rental != null)
            {
                _context.RentalsData.Remove(rental);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
