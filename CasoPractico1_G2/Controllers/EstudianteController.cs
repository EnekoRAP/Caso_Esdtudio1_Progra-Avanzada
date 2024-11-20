using CasoPractico1_G2.Models;
using CasoPractico1_G2.serv;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CasoPractico1_G2.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly ICursoService _cursoService;

        // Lista de estudiantes
        private static List<EstudianteModel> estudiantes = new List<EstudianteModel>
        {
            new EstudianteModel { Id = 1, Nombre = "Juan", Apellido = "Pérez", NumeroIdentificacion = "123456", CursoId = 1 },
            new EstudianteModel { Id = 2, Nombre = "María", Apellido = "González", NumeroIdentificacion = "654321", CursoId = 2 }
        };

        public EstudianteController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        // Mostrar lista de estudiantes
        public IActionResult Estudiante()
        {
            var cursos = _cursoService.ObtenerCursos();
            // Asignar curso a los estudiantes
            foreach (var estudiante in estudiantes)
            {
                estudiante.Curso = cursos.Find(c => c.Cod_Curso == estudiante.CursoId);
            }

            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/Estudiante.cshtml", estudiantes);
        }

        // Mostrar formulario para agregar un nuevo estudiante
        public IActionResult AgregarEstudiante()
        {
            var cursos = _cursoService.ObtenerCursos();
            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/AgregarEstudiante.cshtml");
        }

        [HttpPost]
        public IActionResult AgregarEstudiante(EstudianteModel nuevoEstudiante)
        {
            nuevoEstudiante.Id = estudiantes.Max(e => e.Id) + 1;
            estudiantes.Add(nuevoEstudiante);
            return RedirectToAction("Estudiante");
        }

        // Mostrar formulario para editar un estudiante
        public IActionResult EditarEstudiante(int id)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }

            var cursos = _cursoService.ObtenerCursos();
            ViewBag.Cursos = cursos; // Enviar cursos a la vista
            return View("~/Views/Home/EditarEstudiante.cshtml", estudiante);
        }

        [HttpPost]
        public IActionResult EditarEstudiante(EstudianteModel estudianteActualizado)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Id == estudianteActualizado.Id);
            if (estudiante != null)
            {
                estudiante.Nombre = estudianteActualizado.Nombre;
                estudiante.Apellido = estudianteActualizado.Apellido;
                estudiante.NumeroIdentificacion = estudianteActualizado.NumeroIdentificacion;
                estudiante.CursoId = estudianteActualizado.CursoId;
            }
            return RedirectToAction("Estudiante");
        }

        // Eliminar un estudiante
        [HttpPost]
        public IActionResult EliminarEstudiante(int id)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Id == id);
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
            }
            return RedirectToAction("Estudiante");
        }
    }
}
