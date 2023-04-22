using Cinepolis.Clases;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class verificarCuenta : ContentPage
    {
        String a = "", nombre, apellido, correo, pass, ciudad, nombret, numerot, fechat, codigot;
        public verificarCuenta(String nombre_, String apellido_, String correo_, String pass_, String ciudad_, String nombreT_, String numerot_, String fechat_, String codigot_)
        {
            InitializeComponent();
            // generarCodigo(correo_);
            nombre = nombre_;
            apellido = apellido_;
            correo = correo_;
            pass = pass_;

            ciudad = ciudad_;
            nombret = nombreT_;
            numerot = numerot_;
            fechat = fechat_;
            codigot = codigot_;
        }

        private async void btnVerificar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var session = await App.Supa.Auth.SignUp(correo, pass, new SignUpOptions
                    {
                        Data = new Dictionary<string, object>
                        {
                            { "nombre", "C" },
                            { "apellido", "21" },
                            { "ciudad", ciudad },
                            { "nombret", nombret },
                            { "numerot", numerot },
                            { "fechat", fechat },
                            { "codigot", codigot }
                        }
                });
                if (session != null)
                {
                    await DisplayAlert("¡Cuenta creada exitosamente!", "Corre a iniciar sesión para que disfrutes de nosotros.", "IR");

                    var pagina = new MainPage();
                    await Navigation.PushAsync(pagina);
                }
                else
                {
                    await DisplayAlert("Oooops", "Ha habido un error en la creacion de su cuenta", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Oooops", "Ha habido un error.", "OK");
            }
        }

        //}
            // await DisplayAlert("Oooops", "Codigo incorrecto.", "OK");
        //}


        //void generarCodigo(String email)
        //{
        //    Random rnd = new Random();


        //    for (uint ctr = 1; ctr <= 1; ctr++)
        //    {

        //        a = Convert.ToString(rnd.Next(9999));
        //    }

        //    // WebClient cliente = new WebClient();
        //    // var parametros = new System.Collections.Specialized.NameValueCollection();
        //    // parametros.Add("correo_", email);
        //    // parametros.Add("codigo_", a);
        //    // 
        //    // var direc = new route();
        //    // String direccion = direc.path_();
        //    // direccion = direccion + "Cinepolis/tclientes/correoRegistro.php";
        //    // 
        //    // cliente.UploadValues(direccion, "POST", parametros);

        //}

    }
}