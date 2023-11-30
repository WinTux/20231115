using Microsoft.AspNetCore.Mvc;
using PasosIniciales.Herramientas;
using PasosIniciales.Models;

namespace PasosIniciales.Controllers
{
    [Route("carrito")]
    public class CarritoController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            //rescatar variables de sesion y pasarlas por viewbag
            var items = Conversor.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            ViewBag.carrito = items;
            ViewBag.total = items.Sum(i => i.Producto.Precio * i.Cantidad); // SELECT SUM(precio * cantidad) FROM item.Producto;
            return View();
        }

        [Route("comprar/{id}")]
        public IActionResult Comprar(string id)
        {
            ProductoModel productoModel = new ProductoModel();
            // preguntar si la variable de sesion ya existe
            if(Conversor.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito") == null)
            {
                // si no existe: crear la variable de sesion e ingresar el producto (rescatandolo por su id)
                List<Item> items = new List<Item>();
                items.Add(new Item { Producto = productoModel.GetById(id), Cantidad = 1 });
                Conversor.ObjetoAjson(HttpContext.Session, "carrito", items);
            }
            else
            {
                // si ya existe: verificar si el producto esta dentro el carrito
                List<Item> items = Conversor.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
                int indice = existe(id);// por definir // retornara el indice donde se encuentra el producto
                //                 si esta: incrementamos cantidad
                if (indice != -1)
                    items[indice].Cantidad++;
                //                  si no esta: agregamos producto con cantidad 1 (item)
                else
                    items.Add(new Item { Producto = productoModel.GetById(id), Cantidad = 1 });
                Conversor.ObjetoAjson(HttpContext.Session, "carrito", items);
            }
            return RedirectToAction("index");
        }
        [NonAction]
        private int existe(string id)
        {
            List<Item> items = Conversor.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            for (int i = 0; i < items.Count; i++)
                if (items[i].Producto.Id.Equals(id))
                    return i;
            return -1;
        }

        [Route("eliminar/{id}")]
        public IActionResult Eliminar(string id)
        {
            List<Item> items = Conversor.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            int indice = existe(id);
            items.RemoveAt(indice);
            Conversor.ObjetoAjson(HttpContext.Session, "carrito", items);
            return RedirectToAction("index");
        }
    }


}
