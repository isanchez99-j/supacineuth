using System;
using System.Diagnostics;
using System.Net.Http;


namespace Cinepolis.Clases
{
    public class addClass
    {
        

           public async void registrar(string clave)
        {
            var direc = new Clases.route();
            String direccion = direc.path_();
            direccion = direccion + "Cinepolis/tclientes/insertarLLave.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(clave);

            parametros.Add(email, "llave");

            
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);
                
            }
        }
    }


 
}
