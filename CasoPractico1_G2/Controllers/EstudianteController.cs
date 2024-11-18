using CasoPractico1_G2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasoPractico1_G2.Controllers
{

    public class EstudianteController : Controller
    {
        // Lista de estudiantes y cursos para propósitos de ejemplo
        private static List<EstudianteModel> estudiantes = new List<EstudianteModel>
        {
            new EstudianteModel { Id = 1, Nombre = "Juan", Apellido = "Pérez", NumeroIdentificacion = "123456", CursoId = 1 },
            new EstudianteModel { Id = 2, Nombre = "María", Apellido = "González", NumeroIdentificacion = "654321", CursoId = 2 }
        };

        // Lista de cursos (solo para ejemplo)
        private static List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" }
        };

        public IActionResult Index()
        {
            return View("~/Views/Home/Estudiante.cshtml", estudiantes);  // Esto debe redirigir a la vista "Index"
        }
        public IActionResult Estudiante()
        {
            // Asignamos el curso correspondiente a cada estudiante
            foreach (var estudiante in estudiantes)
            {
                estudiante.Curso = cursos.Find(c => c.Cod_Curso == estudiante.CursoId);
            }

            return View("~/Views/Home/Estudiante.cshtml", estudiantes);
        }
    }
}