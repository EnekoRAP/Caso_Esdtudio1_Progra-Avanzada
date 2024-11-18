using Microsoft.AspNetCore.Mvc;
using CasoPractico1_G2.Models;
using System.Collections.Generic;

namespace CasoPractico1_G2.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Curso()
        {
            var cursos = new List<CursoModel>
            {
                new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
                new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" },
                new CursoModel { Cod_Curso = 3, Nombre = "Historia", Descripcion = "Curso de historia mundial" }
            };


            return View("~/Views/Home/Curso.cshtml", cursos);
        }
    }
}

