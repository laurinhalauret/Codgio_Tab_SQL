using Microsoft.EntityFrameworkCore;
using MeuProjetoAPI.Models;

namespace MeuProjetoAPI.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Eletrodomestico> Eletrodomesticos { get; set; }
        public DbSet<Geladeira> Geladeiras { get; set; }
        public DbSet<Andar> Andares { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
