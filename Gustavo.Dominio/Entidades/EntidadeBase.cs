namespace Gustavo.Dominio.Entidades
{
    public abstract class EntidadeBase<T>
    {
        public T ID { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public EntidadeBase(T id)
        {
            ID = id;
            DataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
        }
    }
}
