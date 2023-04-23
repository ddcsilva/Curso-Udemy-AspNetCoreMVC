using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DaniloLanches.Models;
using DaniloLanches.Interfaces;
using DaniloLanches.ViewModels;

namespace DaniloLanches.Controllers;

/// <summary>
/// Classe responsável por representar o controller da home
/// </summary>
public class HomeController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public HomeController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    /// <summary>
    /// Método responsável por renderizar a view da home
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel
        {
            LanchesPreferidos = _lancheRepository.LanchesPreferidos
        };
        
        return View(homeViewModel);
    }

    /// <summary>
    /// Método responsável por renderizar a view de erro
    /// </summary>
    /// <returns></returns>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
