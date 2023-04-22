using DaniloLanches.Interfaces;
using DaniloLanches.ViewModels;
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
        var lanchesListViewModel = new LancheListViewModel();
        lanchesListViewModel.Lanches = _lancheRepository.Lanches;
        lanchesListViewModel.CategoriaAtual = "Categoria Atual";

        return View(lanchesListViewModel);
    }
}