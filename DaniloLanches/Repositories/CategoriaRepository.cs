using DaniloLanches.Context;
using DaniloLanches.Interfaces;
using DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar o repositório de categorias
/// </summary>
namespace DaniloLanches.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext contexto)
    {
        _context = contexto;
    }

    // Retorna todas as categorias
    public IEnumerable<Categoria> Categorias => _context.Categorias;
}