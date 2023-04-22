using Cinepolis.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Postgrest.Constants;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var User = App.Supa.Auth.CurrentUser;
            var Historial = await App.Supa.From<Historial>().Where(h => h.idUser == User.Id).Order(x => x.idCompra, Ordering.Descending).Get();
            ListaEmpleados.ItemsSource = Historial.Models;
        }


        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Historial;
           
            var pagina = new registroQR(d.idCompra);
            await Navigation.PushAsync(pagina);
        }
    }
}