using DaniloLanches.Models;
using Microsoft.EntityFrameworkCore;

namespace DaniloLanches.Context;

public class AppDbContext : DbContext {
    // Construtor que recebe um objeto do tipo DbContextOptions
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // DbSet é uma coleção de entidades que representa uma tabela no banco de dados
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
}