using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeStone.Integración.Entity;
using PrimeStone.Modelos;
using PrimeStone.Modelos.Dtos;

namespace PrimeStone.Integración.Dao
{
   public class EstudianteDao
    {
        public List<EstudianteDto> ObtenerEstudiantes()
        {
            var estudiantes = new List<EstudianteDto>();

            using (var db= new DBPrimeStoneEntities())
            {
                estudiantes = (from e in db.Estudiante
                                   select new EstudianteDto
                                   {
                                       IdEstudiante = e.IdEstudiante,
                                       Nombre = e.Nombre,
                                       Edad = e.Edad

                                   }).ToList();

            }

            return estudiantes;
        }

        public EstudianteDto ObtenerEstudiante(int id)
        {
            var estudiantes = new EstudianteDto();

            using (var db = new DBPrimeStoneEntities())
            {
                var _estudiantes = db.Estudiante.Find(id);
                estudiantes.IdEstudiante = _estudiantes.IdEstudiante;
                estudiantes.Nombre = _estudiantes.Nombre;
                estudiantes.Edad = _estudiantes.Edad;
            }

            return estudiantes;
        }
        public void InsertarEstudiante( EstudianteDto estudiante)
        {

            using (var db= new DBPrimeStoneEntities())
            {
                var _estudiante = new Estudiante();
                _estudiante.IdEstudiante = estudiante.IdEstudiante;
                _estudiante.Nombre = estudiante.Nombre;
                _estudiante.Edad = estudiante.Edad;
                db.Estudiante.Add(_estudiante);
                db.SaveChanges();
            }
        }
        public void ActualizarEstudiante(EstudianteDto estudiante)
        {
            using (var db = new DBPrimeStoneEntities())
            {
                var _estudiante = new Estudiante();
                _estudiante.IdEstudiante = estudiante.IdEstudiante;
                _estudiante.Nombre = estudiante.Nombre;
                _estudiante.Edad = estudiante.Edad;
                db.Entry(_estudiante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void EliminarEstudiante(int id)
        {
            using (var db = new DBPrimeStoneEntities())
            {
                var _estudiante = db.Estudiante.Find(id);
                db.Estudiante.Remove(_estudiante);
                db.SaveChanges();
            }
        }




    }
}
