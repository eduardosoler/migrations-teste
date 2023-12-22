using Gustavo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Gustavo.Infra.EF.Context
{
    public class GustavoDbContext : DbContext
    {
        public GustavoDbContext(DbContextOptions<GustavoDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
