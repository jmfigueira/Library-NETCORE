using Library.Domain.Interfaces;
using Library.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infra.CrossCutting.InversionOfControl
{
    public static class SqlRepositoryDependency
    {
        public static void AddSqlRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryUser, UserRepository>();
            services.AddScoped<IRepositoryBook, BookRepository>();
        }
    }
}
