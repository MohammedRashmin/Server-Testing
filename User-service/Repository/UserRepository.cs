using System;
using Microsoft.EntityFrameworkCore;
using User_service.Database;
using User_service.Entities;
using User_service.IRepository;

namespace User_service.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.RasUsers.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.RasUsers.FindAsync(id);
        }

        public async Task<User> CreateUser(User user)
        {
            _context.RasUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _context.RasUsers.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await _context.RasUsers.FindAsync(id);
            if (user == null) return false;

            _context.RasUsers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
