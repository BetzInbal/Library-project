using LibraryProject.Models;
using LirbraryProject.Controllers;
using LirbraryProject.Data;
using LirbraryProject.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryProject.Controllers
{

    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
