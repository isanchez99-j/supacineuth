using Cinepolis.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carritoCompra : ContentPage
    {
        string correoG = "", targ="";
        public carritoCompra(string cont, int tp)
        {
            InitializeComponent();
            datoCorreo();
           
            lblFecha.Text = DateTime.Now.ToString();
            lblGolosinas.Text = cont;
            lblTp.Text = tp.ToString();
        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            comprobar();
        }

        async void datoCorreo()
        {
            // var datos = await App.BaseDatos.ObtenerCliente();
            var user = App.Supa.Auth.CurrentUser;
            lblCorreoComprador.Text = user.Email;
            lblComprador.Text = (string)user.UserMetadata["nombre"];
            ubicacion();
        }

        async void subirCompra(string tarjeta_)
        {
            string dato = lblGolosinas.Text + " y su total pagado es de L. " + lblTp.Text + ".00";
            var CompraNueva = new Compra
            {
                descripcion = lblGolosinas.Text,
                lugar = lblLugar.Text,
                total = "L. " + lblTp.Text + ".00",
                tarjeta = tarjeta_,
                correoComprador = lblCorreoComprador.Text,
                fecha = lblFecha.Text,
                idPelicula = 4,
                idUser = App.Supa.Auth.CurrentUser.Id
            };
            var compra = await App.Supa.From<Compra>().Insert(CompraNueva);
 
            correo(dato);
            var pagina = new comidaQR(compra.Models[0].idCompra);
            await Navigation.PushAsync(pagina);
        }

        async void tar()
        {
            var User = App.Supa.Auth.CurrentUser;

            var NumeroTarjeta = (string)User.UserMetadata["numerot"];

            subirCompra(NumeroTarjeta);
        }

        // Rellenar los datos de la ubicacion
        async void ubicacion()
        {
            var userMetadata = App.Supa.Auth.CurrentUser?.UserMetadata;
            var ciudad = userMetadata["ciudad"];

            lblLugar.Text = (string)ciudad;
        }

        // Ir a la siguiente pagina con confirmacion
        async void comprobar()
        {
            try
            {
                var User = App.Supa.Auth.CurrentUser;
                var NumeroTarjeta = (string)User.UserMetadata["numerot"];

                string action = await DisplayActionSheet("¿Desea realizar esta compra?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string action2 = await DisplayActionSheet("¿Desea seleccionar la tarjeta con la terminación (" + NumeroTarjeta.Substring(12, 4) + ") ?", "Cancel", null, "Si", "No");
                    if (action2.Equals("Si"))
                    {
                        tar();
                    }
                }
            }
            catch (Exception ex) { }
        }


        // Mandar notification al correo
        async void correo(string txt)
        {
            string sf = lblFecha.Text;
            var email = lblCorreoComprador.Text;
            var options = new Supabase.Functions.Client.InvokeFunctionOptions
            {
                Headers = new Dictionary<string, string> { { "Authorization", "Bearer " + App.Key } },
                Body = new Dictionary<string, object>
                {
                    { "name", sf },
                    { "email", App.Supa.Auth.CurrentUser.Email }
                }
            };
            // await App.Supa.Functions.Invoke("email", options: options);
        }
    }
}