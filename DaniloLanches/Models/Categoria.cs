namespace DaniloLanches.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    // Propriedade de navegação 1:N - Uma categoria pode ter vários lanches
    public List<Lanche> Lanches { get; set; }
}