using DaniloLanches.Context;
using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using Microsoft.EntityFrameworkCore;

namespace DaniloLanches.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;

    public LancheRepository(AppDbContext contexto)
    {
        _context = contexto;
    }

    // Retorna todos os lanches
    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

    // Retorna os lanches preferidos
    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.LanchePreferido).Include(c => c.Categoria);

    // Retorna um lanche pelo id
    public Lanche ObterLanchePorId(int lancheId) => _context.Lanches.FirstOrDefault(l => l.Id == lancheId);
}