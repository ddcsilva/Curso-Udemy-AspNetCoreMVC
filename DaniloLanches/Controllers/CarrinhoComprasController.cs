using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using DaniloLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DaniloLanches.Controllers;

/// <summary>
/// Classe responsável por representar o controller do carrinho de compras
/// </summary>
public class CarrinhoComprasController : Controller
{
    private readonly ILancheRepository _lancheRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoComprasController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
    {
        _lancheRepository = lancheRepository;
        _carrinhoCompra = carrinhoCompra;
    }

    /// <summary>
    /// Método responsável por renderizar a view do carrinho de compras
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        // Define os itens do carrinho de compras
        var itens = _carrinhoCompra.GetCarrinhoCompraItens();
        _carrinhoCompra.CarrinhoCompraItens = itens;

        // Define o carrinho de compras
        var carrinhoCompraViewModel = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };

        // Retorna a view
        return View(carrinhoCompraViewModel);
    }

    /// <summary>
    /// Método responsável por adicionar um lanche ao carrinho de compras
    /// </summary>
    /// <param name="id">Id do lanche</param>
    /// <returns></returns>
    public RedirectToActionResult Adicionar(int id)
    {
        // Define o lanche
        var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(l => l.Id == id);

        // Verifica se o lanche existe
        if (lancheSelecionado != null)
        {
            // Adiciona o lanche ao carrinho de compras
            _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado, 1);
        }

        // Retorna a view
        return RedirectToAction("Index");
    }
}