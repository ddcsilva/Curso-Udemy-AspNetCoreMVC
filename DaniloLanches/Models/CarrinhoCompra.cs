using DaniloLanches.Context;

namespace DaniloLanches.Models {
    public class CarrinhoCompra {
        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context) {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }

        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services) {
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
    }
}