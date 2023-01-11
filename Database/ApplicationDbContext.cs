using FinalEgzam.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalEgzam.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Residence> Residences { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
    }
}
