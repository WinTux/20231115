using Newtonsoft.Json;

namespace PasosIniciales.Herramientas
{
    public static class Conversor
    {
        //Convertir objeto C# a json
        public static void ObjetoAjson(this ISession session, string llave, object valor)
        {
            session.SetString(llave,JsonConvert.SerializeObject(valor));
        }
        //Convertir json a objeto C#
        public static T JsonAobjeto<T>(this ISession session, string llave) { 
            var valor = session.GetString(llave);
            return valor == null ? default(T) : JsonConvert.DeserializeObject<T>(valor);
        }
            
    }
}
