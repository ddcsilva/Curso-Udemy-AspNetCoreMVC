using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}