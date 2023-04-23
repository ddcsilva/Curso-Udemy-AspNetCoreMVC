using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar o item do carrinho de compras
/// </summary>
[Table("CarrinhoCompraItens")]
public class CarrinhoCompraItem
{
    public int CarrinhoCompraItemId { get; set; }
    public Lanche Lanche { get; set; }
    public int Quantidade { get; set; }

    [StringLength(200)]
    public string CarrinhoCompraId { get; set; }
}