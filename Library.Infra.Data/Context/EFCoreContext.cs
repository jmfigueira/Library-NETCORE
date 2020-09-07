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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(new BookMap().Configure);
        }
    }
}
