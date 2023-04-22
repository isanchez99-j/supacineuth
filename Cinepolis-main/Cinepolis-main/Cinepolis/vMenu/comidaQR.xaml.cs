﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Cinepolis.vMenu
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class comidaQR : ContentPage
    {
        ZXingBarcodeImageView qr;
        public comidaQR(int id)
        {
            InitializeComponent();
            generar(id);
            msj();
        }

        async private void btnSalir_Clicked(object sender, EventArgs e)
        {
            var pagina = new home();
            await Navigation.PushAsync(pagina);
        }
        async void msj()
        {
            await DisplayAlert("Felicidades", "Compra realizada con exito", "OK");
        }
        async void generar(int id)
        {
            qr = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            qr.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            qr.BarcodeOptions.Width = 500;
            qr.BarcodeOptions.Height = 500;
            qr.BarcodeValue = "https://supacineuth.vercel.app/historial/" + id;
            stQR.Children.Add(qr);
        }
    }
}