using FastFoodDeliveryVFE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace FastFoodDeliveryVFE.Models
{
    [DbContext(typeof(ApplicationDbContext))]

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ignorer toutes les relations dans chaque entité
            modelBuilder.Entity<Client>().Ignore(c => c.DeliveryPerson);
            modelBuilder.Entity<Client>().Ignore(c => c.Commandes);

            modelBuilder.Entity<Admin>().Ignore(a => a.Clients);
            modelBuilder.Entity<Admin>().Ignore(a => a.CommandesGerees);
            modelBuilder.Entity<Admin>().Ignore(a => a.Livreurs);

            modelBuilder.Entity<Commande>().Ignore(c => c.Client);
            modelBuilder.Entity<Commande>().Ignore(c => c.Admin);
            modelBuilder.Entity<Commande>().Ignore(c => c.DeliveryPerson);
            modelBuilder.Entity<Commande>().Ignore(c => c.Foods);

            modelBuilder.Entity<DeliveryPerson>().Ignore(d => d.Clients);
            modelBuilder.Entity<DeliveryPerson>().Ignore(d => d.Commandes);
            modelBuilder.Entity<DeliveryPerson>().Ignore(d => d.Admin);

            modelBuilder.Entity<Food>().Ignore(f => f.Commande);
        }

    }
}
