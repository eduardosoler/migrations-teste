using Gustavo.Dominio.Entidades;

namespace Gustavo.Dominio.Repositorios
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        Task<Categoria> ObterPorID(Guid id);
    }
}
