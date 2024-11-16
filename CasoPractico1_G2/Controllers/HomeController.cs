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
                new CursoModel {Cod_Curso = 203, Nombre = "Matem�ticas Discretas", Descripcion = "Introducci�n a la Matem�tica Discreta"},
                new CursoModel {Cod_Curso = 204, Nombre = "Fundamentos de Enrutamiento", Descripcion = "Introducci�n a m�todos de Enrutamiento"},
                new CursoModel {Cod_Curso = 205, Nombre = "Programaci�n Avanzada", Descripcion = "Principios de la programaci�n avanzada"}
            };

            return View(cursos);
        }
    }
}
