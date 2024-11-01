using System.ComponentModel.DataAnnotations;

namespace ApiMeu.Models
{
    public class Mercado
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
