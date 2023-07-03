using Microsoft.AspNetCore.Mvc;
using sales_analysis.Context;
using sales_analysis.Models;
using sales_analysis.Services;
using System.Diagnostics;

namespace sales_analysis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SalesAnalysisContext _context;

        public HomeController(ILogger<HomeController> logger, SalesAnalysisContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var data = new SalesAnalysisService(_context).GetAllSales();
            ViewBag.TopModels = new SalesAnalysisService(_context).GetTopProductByLocation();
            ViewBag.TotalSales = new SalesAnalysisService(_context).GetTotalSales();
            ViewBag.TopProduct = new SalesAnalysisService(_context).GetTopProduct();
            ViewBag.BottomProduct = new SalesAnalysisService(_context).GetBottomProduct();
            return View(data);
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