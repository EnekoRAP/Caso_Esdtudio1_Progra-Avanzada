using Microsoft.AspNetCore.Mvc;
using CasoPractico1_G2.Models;
using System.Collections.Generic;
using System.Linq;

namespace CasoPractico1_G2.Controllers
{
    public class CursoController : Controller
    {
        // Lista estática de cursos como ejemplo
        private static List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Álgebra Lineal", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias Básicas", Descripcion = "Curso de física y química básica" },
            new CursoModel { Cod_Curso = 3, Nombre = "Programación I", Descripcion = "Introducción a la programación con Java y C++" },
            new CursoModel { Cod_Curso = 4, Nombre = "Estructuras de Datos", Descripcion = "Estudio de estructuras de datos como listas, pilas, colas y árboles" },
            new CursoModel { Cod_Curso = 5, Nombre = "Sistemas Operativos", Descripcion = "Fundamentos de sistemas operativos, administración de procesos y memoria" },
            new CursoModel { Cod_Curso = 6, Nombre = "Bases de Datos", Descripcion = "Diseño, implementación y gestión de bases de datos relacionales" },
            new CursoModel { Cod_Curso = 7, Nombre = "Redes de Computadoras", Descripcion = "Estudio de redes, protocolos, y comunicaciones entre computadoras" },
            new CursoModel { Cod_Curso = 8, Nombre = "Desarrollo Web", Descripcion = "Tecnologías y frameworks para el desarrollo de aplicaciones web" },
            new CursoModel { Cod_Curso = 9, Nombre = "Algoritmos", Descripcion = "Teoría y práctica de algoritmos para la resolución de problemas computacionales" },
            new CursoModel { Cod_Curso = 10, Nombre = "Ingeniería de Software", Descripcion = "Principios de desarrollo de software, análisis y diseño de sistemas" }
        };

        // Acción para listar los cursos
        public IActionResult Curso()
        {
            return View("~/Views/Home/Curso.cshtml", cursos);
        }

        // Acción para mostrar el formulario para agregar un curso
        public IActionResult AgregarCurso()
        {
            return View("~/Views/Home/AgregarCurso.cshtml");
        }

        // Acción POST para agregar un curso
        [HttpPost]
        public IActionResult AgregarCurso(CursoModel nuevoCurso)
        {
            if (ModelState.IsValid)
            {
                nuevoCurso.Cod_Curso = cursos.Max(c => c.Cod_Curso) + 1; // Generar nuevo código para el curso
                cursos.Add(nuevoCurso);
                return RedirectToAction("Curso"); // Redirige a la vista que lista los cursos
            }
            return View("~/Views/Home/AgregarCurso.cshtml", nuevoCurso); // Si hay error, vuelve a mostrar el formulario
        }

        // Acción para mostrar el formulario de edición de un curso
        public IActionResult EditarCurso(int codCurso)
        {
            var curso = cursos.FirstOrDefault(c => c.Cod_Curso == codCurso);
            if (curso == null)
            {
                return NotFound(); // Si no se encuentra el curso, retorna un error 404
            }
            return View("~/Views/Home/EditarCurso.cshtml", curso);
        }

        // Acción POST para modificar un curso
        [HttpPost]
        public IActionResult EditarCurso(CursoModel cursoActualizado)
        {
            var curso = cursos.FirstOrDefault(c => c.Cod_Curso == cursoActualizado.Cod_Curso);
            if (curso != null)
            {
                curso.Nombre = cursoActualizado.Nombre;
                curso.Descripcion = cursoActualizado.Descripcion;
            }
            return RedirectToAction("Curso"); // Redirige a la lista de cursos
        }

        // Acción para eliminar un curso
        [HttpPost]
        public IActionResult EliminarCurso(int codCurso)
        {
            var curso = cursos.FirstOrDefault(c => c.Cod_Curso == codCurso);
            if (curso != null)
            {
                cursos.Remove(curso); // Elimina el curso de la lista
            }
            return RedirectToAction("Curso"); // Redirige a la lista de cursos
        }
    }
}

