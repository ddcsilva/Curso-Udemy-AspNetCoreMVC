using DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar o view model do carrinho de compras
/// </summary>
namespace DaniloLanches.ViewModels;

public class CarrinhoCompraViewModel
{
    public CarrinhoCompra CarrinhoCompra { get; set; }
    public decimal CarrinhoCompraTotal { get; set; }
}