using Gustavo.Dominio.Entidades;
using Gustavo.Dominio.Repositorios;
using Gustavo.Infra.EF.Context;

namespace Gustavo.Infra.EF.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly GustavoDbContext _context;
        public CategoriaRepository(GustavoDbContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Categoria entidade)
        {
            _context.Categorias.Update(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Categoria entidade)
        {
            _context.Categorias.Remove(entidade);
            await _context.SaveChangesAsync();
        }

        public Task Inserir(Categoria entidade)
        {
            _context.Categorias.Add(entidade);
            return _context.SaveChangesAsync();
        }

        public async Task<Categoria> ObterPorID(Guid id)
        {
            return await _context.FindAsync<Categoria>(id);
        }
    }
}
