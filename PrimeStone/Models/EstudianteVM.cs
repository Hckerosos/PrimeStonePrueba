using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeStone.Models
{
    public class EstudianteVM
    {
        [Required]
        public int IdEstudiante { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Edad { get; set; }

    }
}