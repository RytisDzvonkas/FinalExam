using FinalEgzam.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalEgzam.Database
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasOne<Residence>(x => x.Residence).WithOne(ad => ad.Person).HasForeignKey<Residence>(ad => ad.PersonId);
            modelBuilder.Entity<Person>().HasOne<User>(x => x.User).WithOne(x => x.Person).HasForeignKey<User>(x => x.PersonId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Residence> Residences { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
    }
}
