using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar o lanche
/// </summary>
[Table("Lanches")]
public class Lanche
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do lanche")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe a descrição curta do lanche")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "A descrição curta deve ter entre 3 e 100 caracteres")]
    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "A descrição detalhada deve ter entre 3 e 200 caracteres")]
    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o preço do lanche")]
    [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco { get; set; }

    [Display(Name = "Imagem")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome da imagem deve ter entre 3 e 200 caracteres")]
    public string ImagemUrl { get; set; }

    [Display(Name = "Imagem Thumbnail")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome da imagem thumbnail deve ter entre 3 e 200 caracteres")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool LanchePreferido { get; set; }

    [Display(Name = "Em estoque?")]
    public bool EmEstoque { get; set; }

    // Chave estrangeira
    public int CategoriaId { get; set; }

    // Propriedade de navegação - Um lanche pertence a uma categoria
    public Categoria Categoria { get; set; }
}