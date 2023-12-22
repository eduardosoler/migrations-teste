namespace Gustavo.Dominio.Repositorios
{
    public interface IRepositoryBase<Entidade>
    {
        Task Inserir(Entidade entidade);
        Task Atualizar(Entidade entidade);
        Task Excluir(Entidade entidade);
    }
}
