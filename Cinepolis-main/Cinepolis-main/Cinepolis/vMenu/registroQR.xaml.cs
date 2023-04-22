using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroQR : ContentPage
    {
        ZXingBarcodeImageView qr;
        public registroQR(int id)
        {
            InitializeComponent();
            generar(id);
        }


        async private void btnSalir_Clicked(object sender, EventArgs e)
        {
            var pagina = new home();
            await Navigation.PushAsync(pagina);
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

        async private void btnSalir_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}