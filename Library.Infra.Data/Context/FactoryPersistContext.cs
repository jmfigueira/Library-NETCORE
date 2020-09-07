using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Library.Infra.Data.Context
{
    public class FactoryPersistContext : IDesignTimeDbContextFactory<EFCoreContext>
    {
        public EFCoreContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public EFCoreContext CreateDbContext(string[] args)
        {
            var builderConfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builderConfiguration.Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<EFCoreContext>();
            builder.UseSqlServer(connectionString);

            return new EFCoreContext(builder.Options);
        }
    }
}
