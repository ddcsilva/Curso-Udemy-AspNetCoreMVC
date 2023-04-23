using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using DaniloLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers;

public class LanchesController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LanchesController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    public IActionResult List(string categoria)
    {
        string _categoria = categoria;
        IEnumerable<Lanche> lanches;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(categoria))
        {
            lanches = _lancheRepository.Lanches.OrderBy(l => l.Id);
            categoriaAtual = "Todos os lanches";
        }
        else
        {
            lanches = _lancheRepository.Lanches.Where(l => l.Categoria.Nome.Equals(categoria)).OrderBy(l => l.Nome);
            categoriaAtual = _categoria;
        };

        var lancheListViewModel = new LancheListViewModel
        {
            Lanches = lanches,
            CategoriaAtual = categoriaAtual
        };

        return View(lancheListViewModel);
    }
}