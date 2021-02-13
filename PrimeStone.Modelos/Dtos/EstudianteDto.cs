using PrimeStone.Modelos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Modelos.Dtos
{
   public class EstudianteDto : IEstudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }

        int IEstudiante.IdEstudiante { get; set; }
        string IEstudiante.Nombre { get; set; }
        string IEstudiante.Edad { get; set; }
    }
}
