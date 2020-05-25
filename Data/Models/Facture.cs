using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace GestionFacturation.Data.Models
{
    public class Facture
    {
        public Facture()
        {
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string Statut { get; set; }
        public string NomClient { get; set; }
        public DateTime DateGeneration { get; set; }
        public DateTime DateEcheance { get; set; }
        [ForeignKey("Devis")]
        public int DevisId { get; set; }
        [ForeignKey("Produit")]
        public int ProduitId { get; set; }
        [ForeignKey("Paiement")]
        public int PaiementId { get; set; }

    }
}
