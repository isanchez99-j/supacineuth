using Cinepolis.Clases;
using Cinepolis.Models;
using Supabase;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;

namespace Cinepolis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblCrearFunc();
            lblOlvidoFunc();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try {
                var currentUser = App.Supa.Auth.CurrentUser;
                if (currentUser != null)
                {
                    var pagina = new vMenu.home();
                    await Navigation.PushAsync(pagina);
                }

            }
            catch (Exception ex)
            {
                var currentUser = App.Supa.Auth.CurrentUser;                
                if (currentUser != null)
                {
                    var pagina = new vMenu.home();
                    await Navigation.PushAsync(pagina);
                }
            }


        }
        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCorreo.Text) || String.IsNullOrWhiteSpace(txtContra.Text))
            {
                await DisplayAlert("Error", "Es necesario llenar los campos", "OK");
            }
            else
            {
                try
                {
                    var session = await App.Supa.Auth.SignInWithPassword(txtCorreo.Text, txtContra.Text);
                    
                    if (session != null)
                    {
                        var pagina = new vMenu.home();
                        await Navigation.PushAsync(pagina);
                    }
                    else
                    {
                        await DisplayAlert("Error", "Datos Incorrectos", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


        void lblCrearFunc()
        {
            lblCrear.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() =>
                {
                    var pagina = new aUsuarios.RegistrarUsuario();

                    Navigation.PushAsync(pagina);
                })
            });

        }


        void lblOlvidoFunc()
        {
            lblOlvido.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() =>
                {
                    var pagina = new aUsuarios.OlvidoContraseña();

                    Navigation.PushAsync(pagina);
                })
            });
        }



    }
}
