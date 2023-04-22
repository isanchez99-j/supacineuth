using Cinepolis.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagarEntrada : ContentPage
    {
        int[] nSilla;

        int contador = 0;
        int id__;
        string nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, banner__, video__, hora__;
        string correo__ = "", nCliente__ = "", ubicacion__ = "";
        int contadorSilla, compraId;
        string sillaNumeros;

        public pagarEntrada(int id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_, string hora_, int[] a)
        {
            string sillaMostrar = "Numero de sillas: ";
            contadorSilla = 0;
            compraId = 0;
            id__ = id_;
            nombre__ = nombre_;
            synopsis__ = synopsis_;
            anio__ = anio_;
            clasificacion__ = clasificacion_;
            genero__ = genero_;
            director__ = director_;
            duracion__ = duracion_;
            banner__ = banner_;
            video__ = video_;
            hora__ = hora_;

            InitializeComponent();


            for (int i = 0; i < 40; i++)
            {
                if (a[i] != 0)
                {
                    // TODO: Fix the number of seats
                    sillaNumeros = a[i].ToString() + ", ";
                    sillaMostrar = sillaMostrar + a[i].ToString() + ", ";
                    contadorSilla++;
                    contador++;
                }
            }
            sillaMostrar = sillaMostrar + "\nTotal de sillas a comprar: (" + contadorSilla.ToString() + ")";


            datoCorreo();

            lblPelicula.Text = nombre_;
            lblFecha.Text = DateTime.Now.ToString();
            lblHora.Text = hora_ + " horas";

            lblDuracion.Text = duracion_;
            lblSillas.Text = sillaMostrar;
            

            int tap = contadorSilla * 100;
            lblTp.Text = "L. " + tap.ToString() + ".00";
            
            correo__ = lblCorreoComprador.Text;
            nCliente__ = lblComprador.Text;
            ubicacion__ = lblLugar.Text;

            nSilla = a;
        }

        async void datoCorreo()
        {
            var user = App.Supa.Auth.CurrentUser;
            var meta = user?.UserMetadata;

            lblCorreoComprador.Text = (string)user.Email;
            lblComprador.Text = (string)meta["nombre"];
            ubicacion(lblCorreoComprador.Text);
        }

        async void ubicacion(string correo)
        {
            var meta = App.Supa.Auth.CurrentUser?.UserMetadata;
            lblLugar.Text = (string)meta["ciudad"];
        }

        async private void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var meta = App.Supa.Auth.CurrentUser?.UserMetadata;
                var numeroTarjeta = (string)meta["numerot"];

                string action = await DisplayActionSheet("¿Desea realizar esta compra?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string action2 = await DisplayActionSheet("¿Desea seleccionar la tarjeta con la terminación ("+numeroTarjeta.Substring(12,4)+") ?", "Cancel", null, "Si", "No");
                    if (action2.Equals("Si"))
                    {
                        for (int i = 0; i < 40; i++)
                        {
                            if (nSilla[i] != 0)
                            {
                                comprarSilla(nSilla[i]);

                            }
                        }
                        subirCompra(numeroTarjeta);
                        correo();
                    }
                }
            }
            catch (Exception ex) { }
        }

        async void comprarSilla(int silla)
        {
            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + silla : silla);
            var update = await App.Supa
                .From<Seat>()
                .Where(seat => seat.id == seatId)
                .Set(seat => seat.busy, true)
                .Update();
        }

        async void subirCompra(string tarjeta_)
        {   int t_p = contador * 100;
            string datoDes = lblSillas.Text + " - La pelicula es: " + nombre__ + " y sera en el horario: " + hora__;

            var desc = contadorSilla + (contadorSilla > 1 ? " boletos" : " boleto") + " para la pelicula " + nombre__ + ". Sillas: " + sillaNumeros;
            desc = desc.Substring(0, desc.Length - 1);
            var CompraNueva = new Compra
            {
                descripcion = desc,
                lugar = lblLugar.Text,
                total = lblTp.Text,
                tarjeta = tarjeta_,
                correoComprador = lblCorreoComprador.Text,
                fecha = lblFecha.Text,
                idPelicula = id__,
                idUser = App.Supa.Auth.CurrentUser.Id,
            };
            var compra = await App.Supa.From<Compra>().Insert(CompraNueva);
            var pagina = new peliculaQR(compra.Models[0].idCompra);
            await Navigation.PushAsync(pagina);
        }

        // TODO: Mandar correo
        async void correo()
        {
            string txt = "Se a realizado la compra de las siguientes sillas: ";
            for (int i = 0; i < 40; i++)
            {
                if (nSilla[i] != 0)
                {
                    txt = txt + nSilla[i].ToString() + " ";
                }
            }

            string sf = lblFecha.Text;
            txt = txt + " con un total a pagar de: " + lblTp.Text + ", la pelicula "+nombre__+" se podra ver en la fecha "+sf.Substring(0,10)+", a las "+lblHora.Text+" en la ciudad de "+lblLugar.Text;
            var options = new Supabase.Functions.Client.InvokeFunctionOptions
            {
                Headers = new System.Collections.Generic.Dictionary<string, string> { { "Authorization", "Bearer " + App.Key } },
                Body = new System.Collections.Generic.Dictionary<string, object>
                {
                    { "name", "Gallo" },
                    { "email", App.Supa.Auth.CurrentUser.Email }
                }
            };
            // await App.Supa.Functions.Invoke("email", options: options);
        }
    }
}