using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeStone.Integración.Dao;
using PrimeStone.Modelos.Dtos;
using PrimeStone.Models;

namespace PrimeStone.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Obtener()
        {
            var estudianteDao = new EstudianteDao();
            var modelo = new List<EstudianteVM>();
            try
            {
                var estudiantes = estudianteDao.ObtenerEstudiantes();
                foreach (var estudiante in estudiantes)
                {
                    modelo.Add(new EstudianteVM { IdEstudiante = estudiante.IdEstudiante, Nombre = estudiante.Nombre, Edad = estudiante.Edad });
                }

                return View(modelo);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult Nuevo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(EstudianteVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var estudianteDao = new EstudianteDao();
                    estudianteDao.InsertarEstudiante(new EstudianteDto { IdEstudiante = model.IdEstudiante, Nombre = model.Nombre, Edad = model.Edad });
                }

                return Redirect("obtener");

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public ActionResult Editar(int id)
        {
            var estudianteDao = new EstudianteDao();
            var modelo = new EstudianteVM();
            var estudiante = estudianteDao.ObtenerEstudiante(id);
            modelo.IdEstudiante = id;
            modelo.Nombre = estudiante.Nombre;
            modelo.Edad = estudiante.Edad;
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Editar(EstudianteVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var estudianteDao = new EstudianteDao();
                    estudianteDao.ActualizarEstudiante(new EstudianteDto { IdEstudiante = model.IdEstudiante, Nombre = model.Nombre, Edad = model.Edad });
                }

                return Redirect("~/estudiante/obtener");

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var estudianteDao = new EstudianteDao();
                    estudianteDao.EliminarEstudiante(id);
                }

                return Redirect("~/estudiante/obtener");

            }
            catch (Exception ex)
            {

                throw;
            }

        }







    }
}