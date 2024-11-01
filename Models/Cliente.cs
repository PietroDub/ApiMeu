using System.ComponentModel.DataAnnotations;

namespace ApiMeu.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
