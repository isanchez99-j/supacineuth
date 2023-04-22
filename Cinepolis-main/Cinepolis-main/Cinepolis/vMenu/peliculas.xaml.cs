using Cinepolis.Controller;
using System;
using System.Diagnostics;
using System.Net.Http;
using Supabase;
using System.Collections.Generic;
using Cinepolis.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class peliculas : ContentPage
    {
        public peliculas()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var userMetadata = App.Supa.Auth.CurrentUser?.UserMetadata;
            var ciudad = userMetadata["ciudad"];
            var Movies = await App.Supa.From<Movie>().Where(movie => movie.location == ciudad).Get();
            ListaEmpleados.ItemsSource = Movies.Models;
        }
        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Movie;
            var pagina = new peliculaElegida(d.idPelicula, d.nombre, d.synopsis, d.anio, d.clasificacion, d.genero, d.director, d.duracion, d.video, d.banner);
            await Navigation.PushAsync(pagina);

        }
    }
}