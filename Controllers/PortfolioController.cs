using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("/portfolio/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
