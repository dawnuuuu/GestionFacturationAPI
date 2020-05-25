using Microsoft.EntityFrameworkCore;
using GestionFacturation.Data.Models;
namespace GestionFacturation.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }
        #endregion Constructor
        #region Methods
        protected override void OnModelCreating(ModelBuilder
        modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Map Entity names to DB Table names
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Devis>().ToTable("Deviss");
            modelBuilder.Entity<Facture>().ToTable("Factures");
            modelBuilder.Entity<Paiement>().ToTable("Paiements");
            modelBuilder.Entity<Produit>().ToTable("Produits");
            modelBuilder.Entity<Utilisateur>().ToTable("Utilisateurs");
        }
        #endregion Methods
        #region Properties
        public DbSet<Client> Clients { get; set; }
        public DbSet<Devis> Deviss { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        #endregion Properties
    }
}
