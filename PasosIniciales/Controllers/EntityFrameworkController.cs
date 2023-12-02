using Microsoft.AspNetCore.Mvc;

namespace PasosIniciales.Controllers
{
    public class EntityFrameworkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
