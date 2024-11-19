using Microsoft.AspNetCore.Mvc;
using CasoPractico1_G2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CasoPractico1_G2.Controllers
{
    public class CursoController : Controller
    {
        private static List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" },
            new CursoModel { Cod_Curso = 3, Nombre = "Historia", Descripcion = "Curso de historia mundial" }
        };

        public IActionResult Curso()
        {
            return View("~/Views/Home/Curso.cshtml", cursos);
        }

        [HttpPost]
        public IActionResult AgregarCurso(CursoModel nuevoCurso)
        {
            nuevoCurso.Cod_Curso = cursos.Max(c => c.Cod_Curso) + 1;
            cursos.Add(nuevoCurso);
            return RedirectToAction("Curso");
        }

        public IActionResult ModificarCurso(CursoModel cursoActualizado)
        {
            var curso = cursos.FirstOrDefault(c => c.Cod_Curso == cursoActualizado.Cod_Curso);
            if (curso != null)
            {
                curso.Nombre = cursoActualizado.Nombre;
                curso.Descripcion = cursoActualizado.Descripcion;
            }
            return RedirectToAction("Curso");
        }
    }
}

