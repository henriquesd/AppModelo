using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("produtos/busca")]
        [Route("busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}