using CasoPractico1_G2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasoPractico1_G2.Controllers
{
    public class ProfesorController : Controller
    {
        // Lista estática de profesores y cursos
        private static List<ProfesorModel> profesores = new List<ProfesorModel>
        {
            new ProfesorModel { Id = 1, Nombre = "Carlos", Apellido = "Sánchez", Email = "carlos@univ.com", CursoId = 1 },
            new ProfesorModel { Id = 2, Nombre = "Ana", Apellido = "Pérez", Email = "ana@univ.com", CursoId = 2 }
        };

        private static List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" }
        };

        public IActionResult Index()
        {
            return View("~/Views/Home/Profesor.cshtml", profesores);  
        }

        public IActionResult Profesor()
        {
            // Asignar el curso correspondiente a cada profesor
            foreach (var profesor in profesores)
            {
                profesor.Curso = cursos.Find(c => c.Cod_Curso == profesor.CursoId);
            }

            return View("~/Views/Home/Profesor.cshtml", profesores);
        }

    }
}

