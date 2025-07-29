using Microsoft.AspNetCore.Mvc;

namespace SistemaAgencia.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
