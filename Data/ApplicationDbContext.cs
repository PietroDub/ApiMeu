using Microsoft.EntityFrameworkCore;
using ApiMeu.Models;

namespace ApiMeu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApiMeu.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<ApiMeu.Models.Compra> Compra { get; set; } = default!;
        public DbSet<ApiMeu.Models.Mercado> Mercado { get; set; } = default!;
        public DbSet<ApiMeu.Models.Produto> Produto { get; set; } = default!;

     
    }
}
