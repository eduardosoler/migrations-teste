namespace Gustavo.Dominio.Entidades
{
    public class Categoria : EntidadeBase<Guid>
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; }

        public Categoria() : base(Guid.NewGuid())
        {
        }
    }
}
