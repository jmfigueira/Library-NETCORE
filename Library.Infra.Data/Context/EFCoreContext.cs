using Library.Domain.Entities;
using Library.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Library.Infra.Data.Context
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Book>(new BookMap().Configure);
        }
    }
}
