using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace PasosIniciales.Controllers
{
    [Route("asp")]
    public class AdoNetController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            string cadenaConexion = "Server=192.168.1.253;Database=Tienda;User=sa;Password=123456ABCxyz";
            SqlConnection conexion = new SqlConnection(cadenaConexion);// cambiar userid
            conexion.Open();

            conexion.Close();
            return View();
        }
    }
}
