
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeu.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("ProdutoMercado")]
        public Guid MercadoId { get; set; } // Relacionamento com Mercado
        public Mercado? Mercado { get; set; }

    }
}
