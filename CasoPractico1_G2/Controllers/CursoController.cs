using Microsoft.AspNetCore.Mvc;

namespace CasoPractico1_G2.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
