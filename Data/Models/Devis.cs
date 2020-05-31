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

    public class Rootobject2
    {
        public Devis Devis { get; set; }
    }

    public class Devis
    {
        [Key]
        public int id { get; set; }
        public string NomClient { get; set; }
        public int ClientId { get; set; }
        public Article Articles { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public float PrixTTC { get; set; }
    }

}
