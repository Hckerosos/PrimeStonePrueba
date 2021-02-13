using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Modelos.Interface
{
    interface IEstudiante
    {
        int IdEstudiante { get; set; }
        string Nombre { get; set; }
        string Edad { get; set; }

    }
}
