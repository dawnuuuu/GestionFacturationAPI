using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace GestionFacturation.Data.Models
{
    public class Utilisateur
    {
        public Utilisateur()
        {
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Username { get; set; }
        public string Adresse { get; set; }





    }
}
