using Cinepolis.Clases;
using Cinepolis.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Cinepolis.Controller
{
    public class peliculasHomeController
    {
        public async static Task<List<ApiPeliculasHome.ph>> ObtenerPeliculasHomeTegus()
        {
            var direc = new route();
            String direccion = direc.path_();
            List<ApiPeliculasHome.ph> listapaises = new List<ApiPeliculasHome.ph>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(direccion + "Cinepolis/tclientes/vistas/vPeliculasHomeTegus.php");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<ApiPeliculasHome.ph>>(contenido);
                }
            }
            return listapaises;
        }



        public async static Task<List<ApiPeliculasHome.ph>> ObtenerPeliculasHomeSPS()
        {
            var direc = new route();
            String direccion = direc.path_();
            List<ApiPeliculasHome.ph> listapaises = new List<ApiPeliculasHome.ph>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(direccion + "Cinepolis/tclientes/vistas/vPeliculasHomeSPS.php");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<ApiPeliculasHome.ph>>(contenido);
                }
            }
            return listapaises;
        }

        public async static Task<List<contructorCompra.h>> ObtenerPagos(string correo)
        {
            var direc = new route();
            String direccion = direc.path_();
            List<contructorCompra.h> listapaises = new List<contructorCompra.h>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(direccion + "Cinepolis/tclientes/vistas/seleccionarCompras.php?email="+correo);
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<contructorCompra.h>>(contenido);
                }
            }
            return listapaises;
        }
    }
}
