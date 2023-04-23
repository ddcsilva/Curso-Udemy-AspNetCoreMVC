using DaniloLanches.Models;
namespace DaniloLanches.Interfaces;

/// <summary>
/// Interface responsável por representar o repositório de categorias
/// </summary>
public interface ICategoriaRepository
{
    // Retorna todas as categorias
    IEnumerable<Categoria> Categorias { get; }
}