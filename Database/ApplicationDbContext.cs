using FinalEgzam.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace FinalEgzam.Database
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<User>().HasOne<Residence>(x => x.Residence).WithOne(ad => ad.User).HasForeignKey<Residence>(ad => ad.UserId);
             modelBuilder.Entity<User>().HasOne<Person>(x => x.Person).WithOne(x => x.User).HasForeignKey<Person>(x => x.UserId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

