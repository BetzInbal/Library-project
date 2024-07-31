using LirbraryProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace LirbraryProject.Controllers
{
    public class CatalogController : Controller
    {
        public readonly ICatalogService _catalogService;
        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;   
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detels()
        {
            var res = _catalogService.GetBooksByGenre("Torah").ToList();
            return View(res);
        }
    }
}
