using LinqEtSeedEF.Models;
using Microsoft.EntityFrameworkCore;

namespace GenerationControleurs.Data
{
    public class LivraisonContext : DbContext
    {
        public LivraisonContext(DbContextOptions<LivraisonContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<CommandePlat> CommandePlats { get; set; }

        public DbSet<Plat> Plats { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
