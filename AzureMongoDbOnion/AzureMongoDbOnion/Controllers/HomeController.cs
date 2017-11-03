using System.Diagnostics;
using System.Threading.Tasks;
using AzureMongoDbOnion.Domain.Services.DbServices;
using Microsoft.AspNetCore.Mvc;
using AzureMongoDbOnion.Models;

namespace AzureMongoDbOnion.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbService _service;

        public HomeController(IDbService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var debtors = await _service.GetAllDebtors();
          

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
