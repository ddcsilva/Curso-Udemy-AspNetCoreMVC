using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers;
/// <summary>
/// Classe responsável por representar o controller de contato
/// </summary>
public class ContatoController : Controller
{
    /// <summary>
    /// Método responsável por renderizar a view de contato
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }
}