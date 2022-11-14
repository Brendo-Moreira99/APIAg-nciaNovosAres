using Microsoft.EntityFrameworkCore;

namespace NovosAresApi.NET.Models
{
    
    public class NovosAresDBContext : DbContext
    {
        public NovosAresDBContext(DbContextOptions<NovosAresDBContext> options)
           : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pacote> Pacotes { get; set; }
    }
}
