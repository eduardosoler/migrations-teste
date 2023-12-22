using Gustavo.Infra.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Gustavo.Infra.DependencyInjection.MigrationFactory
{
    public class GustavoDbContextFactory : IDesignTimeDbContextFactory<GustavoDbContext>
    {
        public GustavoDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<GustavoDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            dbContextBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString),
                options => options.MigrationsAssembly("Gustavo.Infra.DependencyInjection")
                );

            return new GustavoDbContext(dbContextBuilder.Options);
        }
    }
}
