using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gustavo.Dominio.Entidades
{
    public class Produto : EntidadeBase<Guid>
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public Produto() : base(Guid.NewGuid())
        {
        }
    }
}
