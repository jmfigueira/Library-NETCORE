using Library.Domain.Interfaces;
using Library.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceUser, UserService>();
            services.AddScoped<IServiceBook, BookService>();
        }
    }
}
