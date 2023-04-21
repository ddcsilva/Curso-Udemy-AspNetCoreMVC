namespace DaniloLanches.Models;

public class Lanche
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool LanchePreferido { get; set; }
    public bool EmEstoque { get; set; }

    // Chave estrangeira
    public int CategoriaId { get; set; }

    // Propriedade de navegação - Um lanche pertence a uma categoria
    public Categoria Categoria { get; set; }
}