using Gustavo.Dominio.Repositorios;
using Gustavo.Infra.EF.Context;
using Gustavo.Infra.EF.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gustavo.Infra.DependencyInjection
{
    public static class ServicesCollectionExtension
    {
        public static void AddGustavoInfra(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GustavoDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        }
    }
}