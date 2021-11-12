using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidInfectadosOficial.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Birthday { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public string Latitud { get; set; }
        [Required]
        public string Longitud { get; set; }
        [Required]
        public bool IsInfected { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public int NumeroTelf { get; set; }
    }
}
