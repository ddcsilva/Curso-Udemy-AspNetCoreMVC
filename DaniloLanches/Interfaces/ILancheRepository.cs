using DaniloLanches.Models;

namespace DaniloLanches.Interfaces;

public interface ILancheRepository
{
    // Retorna todos os lanches
    IEnumerable<Lanche> Lanches { get; }

    // Retorna os lanches preferidos
    IEnumerable<Lanche> LanchesPreferidos { get; }

    // Retorna um lanche pelo id
    Lanche ObterLanchePorId(int lancheId);
}