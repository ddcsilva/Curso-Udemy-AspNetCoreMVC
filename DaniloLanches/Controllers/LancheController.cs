using DaniloLanches.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers;

public class LanchesController : Controller {
    private readonly ILancheRepository _lancheRepository;

    public LanchesController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;        
    }

    public IActionResult List()
    {
        var lanches = _lancheRepository.Lanches;
        return View(lanches);
    }
}