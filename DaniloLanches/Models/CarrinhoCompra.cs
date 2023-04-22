using DaniloLanches.Context;

namespace DaniloLanches.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }

        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            // Define o serviço de sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // Define o contexto do banco de dados
            var context = services.GetService<AppDbContext>();

            // Define o identificador do carrinho de compras
            string carrinhoCompraId = session.GetString("CarrinhoCompraId") ?? Guid.NewGuid().ToString();

            // Define o identificador do carrinho de compras na sessão
            session.SetString("CarrinhoCompraId", carrinhoCompraId);

            // Retorna o carrinho de compras
            return new CarrinhoCompra(context) { CarrinhoCompraId = carrinhoCompraId };
        }

        public void AdicionarAoCarrinho(Lanche lanche, int quantidade)
        {
            // Define o item do carrinho de compras
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                s => s.Lanche.Id == lanche.Id && s.CarrinhoCompraId == CarrinhoCompraId);

            // Verifica se o item do carrinho de compras existe
            if (carrinhoCompraItem == null)
            {
                // Adiciona o item do carrinho de compras
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };

                // Adiciona o item do carrinho de compras no contexto do banco de dados
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                // Incrementa a quantidade do item do carrinho de compras
                carrinhoCompraItem.Quantidade++;
            }

            // Salva as alterações no contexto do banco de dados
            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Lanche lanche)
        {
            // Define o item do carrinho de compras
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                s => s.Lanche.Id == lanche.Id && s.CarrinhoCompraId == CarrinhoCompraId);

            // Define a quantidade do item do carrinho de compras
            var quantidadeLocal = 0;

            // Verifica se o item do carrinho de compras existe
            if (carrinhoCompraItem != null)
            {
                // Verifica se a quantidade do item do carrinho de compras é maior que 1
                if (carrinhoCompraItem.Quantidade > 1)
                {
                    // Decrementa a quantidade do item do carrinho de compras
                    carrinhoCompraItem.Quantidade--;

                    // Define a quantidade do item do carrinho de compras
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    // Remove o item do carrinho de compras do contexto do banco de dados
                    _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }
            }

            // Salva as alterações no contexto do banco de dados
            _context.SaveChanges();

            // Retorna a quantidade do item do carrinho de compras
            return quantidadeLocal;
        }
    }
}