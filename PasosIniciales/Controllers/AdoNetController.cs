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
            string cadenaConexion = "Server=192.168.1.253;DataBase=Tienda;User ID=sa;Password=123456ABCxyz;Trust Server Certificate=true";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion)) {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("select * from Producto;",conexion)) {
                    using (var reader = comando.ExecuteReader()) {
                        while (reader.Read()) {
                            string id = reader.GetString(0);
                            string nombre = reader.GetString(1);
                            string? foto = reader.GetString(3);
                            ViewBag.id = id;
                            ViewBag.nombre = nombre;

                            ViewBag.foto = foto;
                        }
                        

                    }
                }
            }
            

            
            return View();
        }
    }
}
