using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace GestionFacturation.Data.Models
{
    public class Devis
    {
        public Devis()
        {
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string NomClient { get; set; }
        public DateTime DateCommande { get; }

        public DateTime DateLivraison { get; }
        public IList<Article> Articles { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [ForeignKey("Produit")]
        public int ProduitId { get; set; }


    }

    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public float PrixTTC { get; set; }

    }
}
