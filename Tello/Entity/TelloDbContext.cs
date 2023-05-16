using Microsoft.EntityFrameworkCore;

namespace Tello.Entity
{
    public class TelloDbContext: DbContext
    {

        public TelloDbContext(DbContextOptions<TelloDbContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
