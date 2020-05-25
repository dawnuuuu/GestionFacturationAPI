using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFacturation.Data.Models
{
    public class Paiement
    {
        public Paiement()
        {
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public float PrixTTC { get; set; }
        public string StatutFacture { get; set; }


    }
}
