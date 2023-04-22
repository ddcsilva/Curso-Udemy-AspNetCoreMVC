using DaniloLanches.Models;

public interface ICategoriaRepository
{
    // Retorna todas as categorias
    IEnumerable<Categoria> Categorias { get; }
}