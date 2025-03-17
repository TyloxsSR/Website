using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PCSpecsController : Controller
    {
        [HttpGet]
        [Route("/specs/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
