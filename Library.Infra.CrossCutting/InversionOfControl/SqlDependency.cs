using Library.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Library.Infra.CrossCutting.InversionOfControl
{
    public static class SqlDependency
    {
        public static void AddSqlDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EFCoreContext>(options =>
            {
                var builderConfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
                var configuration = builderConfiguration.Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                options.UseSqlServer(connectionString);
            });
        }
    }
}
