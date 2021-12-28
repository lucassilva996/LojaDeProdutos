using Microsoft.AspNetCore.Mvc;
using LojaProdutos.Application.Interfaces;
using LojaProdutos.Application.ViewModels;

namespace LojaProdutos.Web.Mvc.Controllers
{
    public class LojaProdutosController : Controller
    {
        private ILojaProdutoService _lojaProdutoService;

        public LojaProdutosController(ILojaProdutoService lojaProduto)
        {
            _lojaProdutoService = lojaProduto;
        }
        public IActionResult Index()
        {
            LojaProdutoViewModel model = _lojaProdutoService.GetProdutos();
            return View(model);
        }
    }
}
