using CasoPractico1_G2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CasoPractico1_G2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Curso()
        {
            var cursos = new List<CursoModel>
            {
                new CursoModel {Cod_Curso = 203, Nombre = "Matemáticas Discretas", Descripcion = "Introducción a la Matemática Discreta"},
                new CursoModel {Cod_Curso = 204, Nombre = "Fundamentos de Enrutamiento", Descripcion = "Introducción a métodos de Enrutamiento"},
                new CursoModel {Cod_Curso = 205, Nombre = "Programación Avanzada", Descripcion = "Principios de la programación avanzada"}
            };

            return View(cursos);
        }
    }
}
