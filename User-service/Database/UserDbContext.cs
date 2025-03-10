using Microsoft.EntityFrameworkCore;
using User_service.Entities;

namespace User_service.Database
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> RasUsers { get; set; }
    }
}
