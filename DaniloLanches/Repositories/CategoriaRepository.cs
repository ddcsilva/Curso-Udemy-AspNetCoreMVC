using DaniloLanches.Context;
using DaniloLanches.Interfaces;
using DaniloLanches.Models;

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