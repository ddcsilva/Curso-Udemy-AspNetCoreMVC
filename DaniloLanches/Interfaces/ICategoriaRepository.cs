using DaniloLanches.Models;
namespace DaniloLanches.Interfaces;

public interface ICategoriaRepository
{
    // Retorna todas as categorias
    IEnumerable<Categoria> Categorias { get; }
}