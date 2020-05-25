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
    public class Produit
    {
        public Produit()
        {
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public IList<Categorie> Categories { get; set; }
        public IList<Stock> Stocks { get; set; }

    }
    public class Categorie
    {
        public string Nom { get; set; }
        public int Code { get; set; }
        
    }
    public class Stock
    {
        public int Id { get; set; }
        public float Quantite { get; set; }

    }
}
