using Microsoft.EntityFrameworkCore;

namespace ApiMeu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        DbSet<Cliente> Cliente { get; set; }
    }
}
