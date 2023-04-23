using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar a categoria
/// </summary>
[Table("Categorias")]
public class Categoria
{
    [Key]
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [StringLength(200, MinimumLength = 3, ErrorMessage = "A descrição deve ter entre 3 e 200 caracteres")]
    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    // Propriedade de navegação 1:N - Uma categoria pode ter vários lanches
    public List<Lanche> Lanches { get; set; }
}