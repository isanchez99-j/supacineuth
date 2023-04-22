using Supabase.Gotrue;
using System;
using System.Collections.Generic;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class actualizarContacto : ContentPage
    {
        string nombre = "", apellido = "", ubicacion = "", tarjeta = "", nombreT = "", fechaT = "", codigoT = "", correo="";
        
        public actualizarContacto()
        {
            InitializeComponent();
            RellenarDatos();
        }

        async private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var attrs = new UserAttributes
            {
                Data = new Dictionary<string, object>
                {
                    { "nombre", txtNombre.Text },
                    { "apellido", txtApellidos.Text },
                    { "ciudad", ubicacion },
                    { "nombret", txtNombreT.Text },
                    { "numerot", txtNumero.Text },
                    { "fechat", txtFechaEx.Text },
                    { "codigot", txtCodigo.Text }
                }
            };
            var response = await App.Supa.Auth.Update(attrs);
            await DisplayAlert("¡Datos actualizados exitosamente!", "Tus datos han sido actualizados.", "Ok");
            var pagina = new home();
            await Navigation.PushAsync(pagina);
        }

         private void rbSps_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbSps.IsChecked == true)
            {
                ubicacion = "San Pedro Sula";
            }   
        }

         private void rbTeg_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbTeg.IsChecked == true)
            {
                ubicacion = "Tegucigalpa";
            }
        }

        void RellenarDatos()
        {
            var meta = App.Supa.Auth.CurrentUser?.UserMetadata;
            txtNombre.Text = (string)meta["nombre"];
            nombre = (string)meta["nombre"];
            txtApellidos.Text = (string)meta["apellido"];
            apellido = (string)meta["apellido"];
            if (meta["ciudad"].Equals("San Pedro Sula"))
            {
                rbSps.IsChecked = true;
            }

            else if (meta["ciudad"].Equals("Tegucigalpa"))
            {
                rbTeg.IsChecked = true;
            }
            txtNumero.Text = (string)meta["numerot"];
            tarjeta = (string)meta["numerot"];
            txtNombreT.Text = (string)meta["nombret"];
            nombreT = (string)meta["nombret"];
            txtFechaEx.Text = (string)meta["fechat"];
            fechaT = (string)meta["fechat"];
            txtCodigo.Text = (string)meta["codigot"];
            codigoT = (string)meta["codigot"];

        }
    }
}