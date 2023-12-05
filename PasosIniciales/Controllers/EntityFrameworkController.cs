using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("ef")]
    public class EntityFrameworkController : Controller
    {
        private TiendaDbContext _context;
        public EntityFrameworkController(TiendaDbContext context)
        {
            _context = context;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.productos = _context.Productos.ToList();
            return View();
        }

        [Route("insertar")]
        [HttpGet]
        public IActionResult Insertar()
        {
            return View();
        }

        [Route("insertar")]
        [HttpPost]
        public IActionResult Insertar(Producto3 producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [Route("modificar")]
        [HttpGet]
        public IActionResult Modificar()
        {
            return View();
        }

        [Route("modificar")]
        [HttpPost]
        public IActionResult Modificar(Producto3 producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [Route("eliminar")]
        [HttpGet]
        public IActionResult Eliminar()
        {
            return View();
        }

        [Route("eliminar")]
        [HttpPost]
        public IActionResult Eliminar(string id)
        {
            _context.Productos.Remove(_context.Productos.Find(id));
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
