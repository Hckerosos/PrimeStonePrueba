//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrimeStone
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiante_Curso
    {
        public int Id { get; set; }
        public Nullable<int> Estudiante { get; set; }
        public Nullable<int> Curso { get; set; }
    
        public virtual Estudiante Estudiante1 { get; set; }
        public virtual Table Table { get; set; }
    }
}
