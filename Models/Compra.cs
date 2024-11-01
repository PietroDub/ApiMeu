using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeu.Models
{
    public class Compra
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCompra { get; set; }
        public int Quantidade { get; set; }

        [ForeignKey("CompraCliente")]
        public Guid ClienteId { get; set; } // Relacionamento com Cliente

        [ForeignKey("CompraProduto")]
        public Guid ProdutoId { get; set; } // Relacionamento com Produto

        public Cliente? Cliente { get; set; }
        public Produto? Produto { get; set; }
    }
}
