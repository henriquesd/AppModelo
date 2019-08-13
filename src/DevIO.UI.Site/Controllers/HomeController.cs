using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;

        // O MVC vai passar para o construtor, conforme está configurado no Startup (no ConfigureServices);
        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View();
        }

        // Se por algum motivo você não possa mecher no construtor, é possível injetar depedência através do
        // atributo FromServices (mas a melhor forma de injetar uma dependência, é no construtor). Por exemplo:
        //public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        //{
        //    var pedido = _pedidoRepository.ObterPedido();

        //    return View();
        //}

    }
}
