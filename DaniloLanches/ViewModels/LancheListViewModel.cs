using DaniloLanches.Models;

namespace DaniloLanches.ViewModels;

/// <summary>
/// Classe responsável por representar o view model da lista de lanches
/// </summary>
public class LancheListViewModel
{
    public IEnumerable<Lanche> Lanches { get; set; }
    public string CategoriaAtual { get; set; }
}