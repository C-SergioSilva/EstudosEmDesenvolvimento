using Microsoft.AspNetCore.Mvc;
using PraticandoProgramção.MVC.Entidades;
using PraticandoProgramção.MVC.Models;
using PraticandoProgramção.MVC.Sql_Server;
using System.Diagnostics;

namespace PraticandoProgramção.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ClubesFutebol clubes = new ClubesFutebol();
        SqlServer sql = new SqlServer(); 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listClubes = new List<ClubesFutebol>();
            listClubes = sql.BuscarDados();
            return View(listClubes);
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