using System;
using System.Diagnostics;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class horarios : ContentPage
    {
        int id__;
        string nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, banner__, video__;

        public horarios(int id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_)
        {
            InitializeComponent();


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

            rbCinco.IsVisible = false;
            rbTres.IsVisible = false;
            rbSiete.IsVisible = false;

            // horario Funcion #
            horarioFTres();
            horarioFCinco();
            horarioFSiete();

        }
        async void horarioFTres()
        {
            var rsp = "si";

            if (rsp.Equals("si"))
            {
                rbTres.IsVisible = true;
            }

        }

        async void horarioFCinco()
        {
            var rsp = "si";

            if (rsp.Equals("si"))
            {
                rbCinco.IsVisible = true;
            }

        }

        async void horarioFSiete()
        {
            var rsp = "si";

            if (rsp.Equals("si"))
            {
                rbSiete.IsVisible = true;
            }

        }

        async private void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void rbSiete_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (rbSiete.IsChecked == true)
                {
                    string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 19:00?", "Cancel", null, "Si", "No");
                    if (action.Equals("Si"))
                    {
                        string hora__ = "19:00";
                        var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                        await Navigation.PushAsync(pagina);
                    }
                }
            }
            catch (Exception ex) {  }
        }

        async private void rbCinco_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (rbCinco.IsChecked == true)
                {
                    string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 17:00?", "Cancel", null, "Si", "No");
                    if (action.Equals("Si"))
                    {
                        string hora__ = "17:00";
                        var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                        await Navigation.PushAsync(pagina);
                    }
                }
            }
            catch (Exception ex) { }
        }

        async private void rbTres_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (rbTres.IsChecked == true)
                {
                    string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 15:00?", "Cancel", null, "Si", "No");
                    if (action.Equals("Si"))
                    {
                        string hora__ = "15:00";
                        var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                        await Navigation.PushAsync(pagina);
                    }
                }
            }
            catch (Exception ex) { }
        }




    }
}