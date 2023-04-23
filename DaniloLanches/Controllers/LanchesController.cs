using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using DaniloLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers;

/// <summary>
/// Classe responsável por representar o controller de lanches
/// </summary>
public class LanchesController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LanchesController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    /// <summary>
    /// Método responsável por renderizar a view de listagem de lanches
    /// </summary>
    /// <param name="categoria"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Método responsável por renderizar a view de detalhes do lanche
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public IActionResult Details(int Id)
    {
        var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.Id == Id);

        if (lanche == null)
        {
            return View("~/Views/Error/Error.cshtml");
        }

        return View(lanche);
    }
}