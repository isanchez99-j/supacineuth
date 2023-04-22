using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarUsuario : ContentPage
    {

        String nombre = "", apellido = "", correo = "", contraseña = "", ciudad = "", nombreT = "", numeroT = "", fechaT = "", codigoT = "";
        DateTime ultima;
        private void txtFechaN_DateSelected(object sender, DateChangedEventArgs e)
        {
            ultima = e.NewDate;
        }

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {
            RellenarDatos();
            int cant = numeroT.Length;

            if (String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(apellido) || String.IsNullOrWhiteSpace(correo) || String.IsNullOrWhiteSpace(contraseña) || String.IsNullOrWhiteSpace(nombreT) || String.IsNullOrWhiteSpace(numeroT) || String.IsNullOrWhiteSpace(fechaT) || String.IsNullOrWhiteSpace(codigoT) || cant !=16)
            {
                await DisplayAlert("Error", "Es necesario llenar todos los campos correctamente.", "OK");
            }
            else
            {
                try
                {
                    var session = await App.Supa.Auth.SignUp(correo, contraseña, new SignUpOptions
                    {
                        Data = new Dictionary<string, object>
                        {
                            { "nombre", nombre },
                            { "apellido", apellido },
                            { "ciudad", ciudad },
                            { "nombret", nombreT },
                            { "numerot", numeroT },
                            { "fechat", fechaT },
                            { "codigot", codigoT }
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
        }

        void RellenarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellidos.Text;
            correo = txtCorreo.Text;
            contraseña = txtPass.Text;

            try
            {
                ciudad = txtCiudad.SelectedItem.ToString();
            }
            catch (Exception)
            {
                ciudad = "San Pedro Sula";
            }

            nombreT = txtNombreT.Text;
            numeroT = txtNumero.Text;
            fechaT = txtFechaEx.Text;
            codigoT = txtCodigo.Text;
        }


    }
}