using DaniloLanches.Models;
using DaniloLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Components;

/// <summary>
/// Classe responsável por renderizar o componente de resumo do carrinho de compras
/// </summary>
public class CarrinhoCompraResumo : ViewComponent
{
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
    {
        _carrinhoCompra = carrinhoCompra;
    }

    /// <summary>
    /// Método responsável por renderizar o componente de resumo do carrinho de compras
    /// </summary>
    /// <returns></returns>
    public IViewComponentResult Invoke()
    {
        // Define os itens do carrinho de compras
        var itens = _carrinhoCompra.GetCarrinhoCompraItens();
        _carrinhoCompra.CarrinhoCompraItens = itens;

        // Define o carrinho de compras
        var carrinhoCompraResumoViewModel = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };

        // Retorna a view
        return View(carrinhoCompraResumoViewModel);
    }
}