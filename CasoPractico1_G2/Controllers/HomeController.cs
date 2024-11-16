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
                new CursoModel { Cod_Curso = 101, Nombre = "Progra Avanzada", Descripcion = "Curso de programación avanzada" },
                new CursoModel { Cod_Curso = 102, Nombre = "BD NosQL", Descripcion = "Curso de base de datos no relacionales" },
                new CursoModel { Cod_Curso = 103, Nombre = "Big Data", Descripcion = "Curso de big data" }
            };

            return View(cursos);
        }
    }
}
