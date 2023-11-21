using Microsoft.AspNetCore.Mvc;

namespace PasosIniciales.Controllers
{
    [Route("settings")]
    public class AppSettingsController : Controller
    {
        private IConfiguration configuration;

        public AppSettingsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.valor1 = configuration["Mensaje"];
            ViewBag.valor2 = configuration["MisConfiguraciones:configuracion_01"];
            ViewBag.valor3 = configuration["MisConfiguraciones:configuracion_02"];
            ViewBag.valor4 = configuration["MisConfiguraciones:configuracion_03"];
            ViewBag.valor5 = configuration["Login:Debug:LogLevel:Default"];

            return View();
        }
    }
}
