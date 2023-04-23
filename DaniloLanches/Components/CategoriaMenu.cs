using DaniloLanches.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Components;

/// <summary>
/// Classe responsável por renderizar o componente de menu de categorias
/// </summary>
public class CategoriaMenu : ViewComponent
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaMenu(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    /// <summary>
    /// Método responsável por renderizar o componente de menu de categorias
    /// </summary>
    /// <returns></returns>
    public IViewComponentResult Invoke()
    {
        var categorias = _categoriaRepository.Categorias;

        return View(categorias);
    }
}