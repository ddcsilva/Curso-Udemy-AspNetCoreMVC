using DaniloLanches.Context;
using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using Microsoft.EntityFrameworkCore;

namespace DaniloLanches.Repositories;

/// <summary>
/// Classe responsável por representar o repositório de lanches
/// </summary>
public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;

    public LancheRepository(AppDbContext contexto)
    {
        _context = contexto;
    }

    /// <summary>
    /// Método responsável por retornar todos os lanches
    /// </summary>
    /// <returns>Lista de lanches</returns>
    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

    /// <summary>
    /// Método responsável por retornar todos os lanches preferidos
    /// </summary>
    /// <returns>Lista de lanches preferidos</returns>
    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.LanchePreferido).Include(c => c.Categoria);

    /// <summary>
    /// Método responsável por retornar o lanche pelo id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Lanche</returns>
    public Lanche ObterLanchePorId(int id) => _context.Lanches.FirstOrDefault(l => l.Id == id);
}