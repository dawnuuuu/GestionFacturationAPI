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
    public class Rootobject
    {
        public Produit produit { get; set; }
    }

    public class Produit
    {
        [Key]
        [Required]
        public int id { get; set; }
        public Categorie categorie { get; set; }
        public Stock stock { get; set; }
        public byte[] Image { get; set; }

    }

    public class Categorie
    {
        public int id { get; set; }
        public string nom { get; set; }
        public int code { get; set; }
    }

    public class Stock
    {
        public int id { get; set; }
        public int quantite { get; set; }
    }
}
