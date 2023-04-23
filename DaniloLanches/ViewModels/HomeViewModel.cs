using DaniloLanches.Models;

namespace DaniloLanches.ViewModels;

/// <summary>
/// Classe responsável por representar o view model da home
/// </summary>
public class HomeViewModel
{
    public IEnumerable<Lanche> LanchesPreferidos { get; set; }
}