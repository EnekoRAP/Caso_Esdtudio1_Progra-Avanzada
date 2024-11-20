using CasoPractico1_G2.Models;
using CasoPractico1_G2.serv;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CasoPractico1_G2.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly ICursoService _cursoService;

        // Lista de profesores
        private static List<ProfesorModel> profesores = new List<ProfesorModel>
        {
           new ProfesorModel { Id = 1, Nombre = "Carlos", Apellido = "Sánchez", Email = "carlos@univ.com", CursoId = 1 },
           new ProfesorModel { Id = 2, Nombre = "Ana", Apellido = "Pérez", Email = "ana@univ.com", CursoId = 2 },
           new ProfesorModel { Id = 3, Nombre = "Luis", Apellido = "Gómez", Email = "luis@univ.com", CursoId = 3 },
           new ProfesorModel { Id = 4, Nombre = "María", Apellido = "Rodríguez", Email = "maria@univ.com", CursoId = 4 },
           new ProfesorModel { Id = 5, Nombre = "José", Apellido = "Martínez", Email = "jose@univ.com", CursoId = 8 },
           new ProfesorModel { Id = 6, Nombre = "Patricia", Apellido = "López", Email = "patricia@univ.com", CursoId = 9 },
           new ProfesorModel { Id = 7, Nombre = "Pedro", Apellido = "Hernández", Email = "pedro@univ.com", CursoId = 5 },
           new ProfesorModel { Id = 8, Nombre = "Julia", Apellido = "Fernández", Email = "julia@univ.com", CursoId = 6 },
           new ProfesorModel { Id = 9, Nombre = "Fernando", Apellido = "García", Email = "fernando@univ.com", CursoId = 7 },
           new ProfesorModel { Id = 10, Nombre = "Isabel", Apellido = "Moreno", Email = "isabel@univ.com", CursoId = 4 }
        };

        public ProfesorController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        // Mostrar lista de profesores
        public IActionResult Profesor()
        {
            var cursos = _cursoService.ObtenerCursos();
            foreach (var profesor in profesores)
            {
                profesor.Curso = cursos.Find(c => c.Cod_Curso == profesor.CursoId) ?? new CursoModel { Nombre = "No asignado" };
            }

            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/Profesor.cshtml", profesores);
        }

        // Mostrar formulario para agregar un nuevo profesor
        public IActionResult AgregarProfesor()
        {
            var cursos = _cursoService.ObtenerCursos();
            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/AgregarProfesor.cshtml");
        }

        [HttpPost]
        public IActionResult AgregarProfesor(ProfesorModel nuevoProfesor)
        {
            nuevoProfesor.Id = profesores.Max(p => p.Id) + 1;
            profesores.Add(nuevoProfesor);
            return RedirectToAction("Profesor");
        }

        // Mostrar formulario para editar un profesor
        public IActionResult EditarProfesor(int id)
        {
            var profesor = profesores.FirstOrDefault(p => p.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }

            var cursos = _cursoService.ObtenerCursos();
            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/EditarProfesor.cshtml", profesor);
        }

        [HttpPost]
        public IActionResult EditarProfesor(ProfesorModel profesorActualizado)
        {
            var profesor = profesores.FirstOrDefault(p => p.Id == profesorActualizado.Id);
            if (profesor != null)
            {
                profesor.Nombre = profesorActualizado.Nombre;
                profesor.Apellido = profesorActualizado.Apellido;
                profesor.Email = profesorActualizado.Email;
                profesor.CursoId = profesorActualizado.CursoId;
            }
            return RedirectToAction("Profesor");
        }

        // Eliminar un profesor
        [HttpPost]
        public IActionResult EliminarProfesor(int id)
        {
            var profesor = profesores.FirstOrDefault(p => p.Id == id);
            if (profesor != null)
            {
                profesores.Remove(profesor);
            }
            return RedirectToAction("Profesor");
        }
    }
}

