﻿using Cinepolis.Models;
using System;
using System.Diagnostics;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class silla : ContentPage
    {
        public string rsp = "si";
        int cbtn1 = 0, cbtn2 = 0, cbtn3 = 0, cbtn4 = 0, cbtn5 = 0;
        int cbtn6 = 0, cbtn7 = 0, cbtn8 = 0, cbtn9 = 0, cbtn10 = 0;
        int cbtn11 = 0, cbtn12 = 0, cbtn13 = 0, cbtn14 = 0, cbtn15 = 0;
        int cbtn16 = 0, cbtn17 = 0, cbtn18 = 0, cbtn19 = 0, cbtn20 = 0;
        int cbtn21 = 0, cbtn22 = 0, cbtn23 = 0, cbtn24 = 0, cbtn25 = 0;
        int cbtn26 = 0, cbtn27 = 0, cbtn28 = 0, cbtn29 = 0, cbtn30 = 0;
        int cbtn31 = 0, cbtn32 = 0, cbtn33 = 0, cbtn34 = 0, cbtn35 = 0;
        int cbtn36 = 0, cbtn37 = 0, cbtn38 = 0, cbtn39 = 0, cbtn40 = 0;

        int contador = 0;
        int id__;
        string nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, banner__, video__, hora__;

        public silla(int id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_, string hora_)
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
            hora__ = hora_;


            consuta1();
            consuta2();
            consuta3();
            consuta4();
            consuta5();
            consuta6();
            consuta7();
            consuta8();
            consuta9();
            consuta10();

            consuta11();
            consuta12();
            consuta13();
            consuta14();
            consuta15();
            consuta16();
            consuta17();
            consuta18();
            consuta19();
            consuta20();

            consuta21();
            consuta22();
            consuta23();
            consuta24();
            consuta25();
            consuta26();
            consuta27();
            consuta28();
            consuta29();
            consuta30();

            consuta31();
            consuta32();
            consuta33();
            consuta34();
            consuta35();
            consuta36();
            consuta37();
            consuta38();
            consuta39();
            consuta40();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (cbtn1 == 0)
            {
                btn1.BackgroundColor = Color.Green;
                cbtn1 = 1;
                contador++;
            }
            else
            {
                btn1.BackgroundColor = Color.Default;
                cbtn1 = 0;
                contador--;
            }

            contadorF();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (cbtn2 == 0)
            {
                btn2.BackgroundColor = Color.Green;
                cbtn2 = 1;
                contador++;
            }
            else
            {
                btn2.BackgroundColor = Color.Default;
                cbtn2 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (cbtn3 == 0)
            {
                btn3.BackgroundColor = Color.Green;
                cbtn3 = 1;
                contador++;
            }
            else
            {
                btn3.BackgroundColor = Color.Default;
                cbtn3 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (cbtn4 == 0)
            {
                btn4.BackgroundColor = Color.Green;
                cbtn4 = 1;
                contador++;
            }
            else
            {
                btn4.BackgroundColor = Color.Default;
                cbtn4 = 0;
                contador--;
            }
            contadorF();
        }


        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (cbtn5 == 0)
            {
                btn5.BackgroundColor = Color.Green;
                cbtn5 = 1;
                contador++;
            }
            else
            {
                btn5.BackgroundColor = Color.Default;
                cbtn5 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (cbtn6 == 0)
            {
                btn6.BackgroundColor = Color.Green;
                cbtn6 = 1;
                contador++;
            }
            else
            {
                btn6.BackgroundColor = Color.Default;
                cbtn6 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (cbtn7 == 0)
            {
                btn7.BackgroundColor = Color.Green;
                cbtn7 = 1;
                contador++;
            }
            else
            {
                btn7.BackgroundColor = Color.Default;
                cbtn7 = 0;
                contador--;
            }
            contadorF();
        }


        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (cbtn8 == 0)
            {
                btn8.BackgroundColor = Color.Green;
                cbtn8 = 1;
                contador++;
            }
            else
            {
                btn8.BackgroundColor = Color.Default;
                cbtn8 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (cbtn9 == 0)
            {
                btn9.BackgroundColor = Color.Green;
                cbtn9 = 1;
                contador++;
            }
            else
            {
                btn9.BackgroundColor = Color.Default;
                cbtn9 = 0;
                contador--;
            }
            contadorF();
        }


        private void btn10_Clicked(object sender, EventArgs e)
        {
            if (cbtn10 == 0)
            {
                btn10.BackgroundColor = Color.Green;
                cbtn10 = 1;
                contador++;
            }
            else
            {
                btn10.BackgroundColor = Color.Default;
                cbtn10 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn11_Clicked(object sender, EventArgs e)
        {
            if (cbtn11 == 0)
            {
                btn11.BackgroundColor = Color.Green;
                cbtn11 = 1;
                contador++;
            }
            else
            {
                btn11.BackgroundColor = Color.Default;
                cbtn11 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn12_Clicked(object sender, EventArgs e)
        {
            if (cbtn12 == 0)
            {
                btn12.BackgroundColor = Color.Green;
                cbtn12 = 1;
                contador++;
            }
            else
            {
                btn12.BackgroundColor = Color.Default;
                cbtn12 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn13_Clicked(object sender, EventArgs e)
        {
            if (cbtn13 == 0)
            {
                btn13.BackgroundColor = Color.Green;
                cbtn13 = 1;
                contador++;
            }
            else
            {
                btn13.BackgroundColor = Color.Default;
                cbtn13 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn14_Clicked(object sender, EventArgs e)
        {
            if (cbtn14 == 0)
            {
                btn14.BackgroundColor = Color.Green;
                cbtn14 = 1;
                contador++;
            }
            else
            {
                btn14.BackgroundColor = Color.Default;
                cbtn14 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn15_Clicked(object sender, EventArgs e)
        {
            if (cbtn15 == 0)
            {
                btn15.BackgroundColor = Color.Green;
                cbtn15 = 1;
                contador++;
            }
            else
            {
                btn15.BackgroundColor = Color.Default;
                cbtn15 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn16_Clicked(object sender, EventArgs e)
        {
            if (cbtn16 == 0)
            {
                btn16.BackgroundColor = Color.Green;
                cbtn16 = 1;
                contador++;
            }
            else
            {
                btn16.BackgroundColor = Color.Default;
                cbtn16 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn17_Clicked(object sender, EventArgs e)
        {
            if (cbtn17 == 0)
            {
                btn17.BackgroundColor = Color.Green;
                cbtn17 = 1;
                contador++;
            }
            else
            {
                btn17.BackgroundColor = Color.Default;
                cbtn17 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn18_Clicked(object sender, EventArgs e)
        {
            if (cbtn18 == 0)
            {
                btn18.BackgroundColor = Color.Green;
                cbtn18 = 1;
                contador++;
            }
            else
            {
                btn18.BackgroundColor = Color.Default;
                cbtn18 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn19_Clicked(object sender, EventArgs e)
        {
            if (cbtn19 == 0)
            {
                btn19.BackgroundColor = Color.Green;
                cbtn19 = 1;
                contador++;
            }
            else
            {
                btn19.BackgroundColor = Color.Default;
                cbtn19 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn20_Clicked(object sender, EventArgs e)
        {
            if (cbtn20 == 0)
            {
                btn20.BackgroundColor = Color.Green;
                cbtn20 = 1;
                contador++;
            }
            else
            {
                btn20.BackgroundColor = Color.Default;
                cbtn20 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn21_Clicked(object sender, EventArgs e)
        {
            if (cbtn21 == 0)
            {
                btn21.BackgroundColor = Color.Green;
                cbtn21 = 1;
                contador++;
            }
            else
            {
                btn21.BackgroundColor = Color.Default;
                cbtn21 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn22_Clicked(object sender, EventArgs e)
        {
            if (cbtn22 == 0)
            {
                btn22.BackgroundColor = Color.Green;
                cbtn22 = 1;
                contador++;
            }
            else
            {
                btn22.BackgroundColor = Color.Default;
                cbtn22 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn23_Clicked(object sender, EventArgs e)
        {
            if (cbtn23 == 0)
            {
                btn23.BackgroundColor = Color.Green;
                cbtn23 = 1;
                contador++;
            }
            else
            {
                btn23.BackgroundColor = Color.Default;
                cbtn23 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn24_Clicked(object sender, EventArgs e)
        {
            if (cbtn24 == 0)
            {
                btn24.BackgroundColor = Color.Green;
                cbtn24 = 1;
                contador++;
            }
            else
            {
                btn24.BackgroundColor = Color.Default;
                cbtn24 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn25_Clicked(object sender, EventArgs e)
        {
            if (cbtn25 == 0)
            {
                btn25.BackgroundColor = Color.Green;
                cbtn25 = 1;
                contador++;
            }
            else
            {
                btn25.BackgroundColor = Color.Default;
                cbtn25 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn26_Clicked(object sender, EventArgs e)
        {
            if (cbtn26 == 0)
            {
                btn26.BackgroundColor = Color.Green;
                cbtn26 = 1;
                contador++;
            }
            else
            {
                btn26.BackgroundColor = Color.Default;
                cbtn26 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn27_Clicked(object sender, EventArgs e)
        {
            if (cbtn27 == 0)
            {
                btn27.BackgroundColor = Color.Green;
                cbtn27 = 1;
                contador++;
            }
            else
            {
                btn27.BackgroundColor = Color.Default;
                cbtn27 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn28_Clicked(object sender, EventArgs e)
        {
            if (cbtn28 == 0)
            {
                btn28.BackgroundColor = Color.Green;
                cbtn28 = 1;
                contador++;
            }
            else
            {
                btn28.BackgroundColor = Color.Default;
                cbtn28 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn29_Clicked(object sender, EventArgs e)
        {
            if (cbtn29 == 0)
            {
                btn29.BackgroundColor = Color.Green;
                cbtn29 = 1;
                contador++;
            }
            else
            {
                btn29.BackgroundColor = Color.Default;
                cbtn29 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn30_Clicked(object sender, EventArgs e)
        {
            if (cbtn30 == 0)
            {
                btn30.BackgroundColor = Color.Green;
                cbtn30 = 1;
                contador++;
            }
            else
            {
                btn30.BackgroundColor = Color.Default;
                cbtn30 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn31_Clicked(object sender, EventArgs e)
        {
            if (cbtn31 == 0)
            {
                btn31.BackgroundColor = Color.Green;
                cbtn31 = 1;
                contador++;
            }
            else
            {
                btn31.BackgroundColor = Color.Default;
                cbtn31 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn32_Clicked(object sender, EventArgs e)
        {
            if (cbtn32 == 0)
            {
                btn32.BackgroundColor = Color.Green;
                cbtn32 = 1;
                contador++;
            }
            else
            {
                btn32.BackgroundColor = Color.Default;
                cbtn32 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn33_Clicked(object sender, EventArgs e)
        {
            if (cbtn33 == 0)
            {
                btn33.BackgroundColor = Color.Green;
                cbtn33 = 1;
                contador++;
            }
            else
            {
                btn33.BackgroundColor = Color.Default;
                cbtn33 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn34_Clicked(object sender, EventArgs e)
        {
            if (cbtn34 == 0)
            {
                btn34.BackgroundColor = Color.Green;
                cbtn34 = 1;
                contador++;
            }
            else
            {
                btn34.BackgroundColor = Color.Default;
                cbtn34 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn35_Clicked(object sender, EventArgs e)
        {
            if (cbtn35 == 0)
            {
                btn35.BackgroundColor = Color.Green;
                cbtn35 = 1;
                contador++;
            }
            else
            {
                btn35.BackgroundColor = Color.Default;
                cbtn35 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn36_Clicked(object sender, EventArgs e)
        {
            if (cbtn36 == 0)
            {
                btn36.BackgroundColor = Color.Green;
                cbtn36 = 1;
                contador++;
            }
            else
            {
                btn36.BackgroundColor = Color.Default;
                cbtn36 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn37_Clicked(object sender, EventArgs e)
        {
            if (cbtn37 == 0)
            {
                btn37.BackgroundColor = Color.Green;
                cbtn37 = 1;
                contador++;
            }
            else
            {
                btn37.BackgroundColor = Color.Default;
                cbtn37 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn38_Clicked(object sender, EventArgs e)
        {
            if (cbtn38 == 0)
            {
                btn38.BackgroundColor = Color.Green;
                cbtn38 = 1;
                contador++;
            }
            else
            {
                btn38.BackgroundColor = Color.Default;
                cbtn38 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn39_Clicked(object sender, EventArgs e)
        {
            if (cbtn39 == 0)
            {
                btn39.BackgroundColor = Color.Green;
                cbtn39 = 1;
                contador++;
            }
            else
            {
                btn39.BackgroundColor = Color.Default;
                cbtn39 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn40_Clicked(object sender, EventArgs e)
        {
            if (cbtn40 == 0)
            {
                btn40.BackgroundColor = Color.Green;
                cbtn40 = 1;
                contador++;
            }
            else
            {
                btn40.BackgroundColor = Color.Default;
                cbtn40 = 0;
                contador--;
            }
            contadorF();
        }

        void contadorF()
        {
            lblCantidad.Text = "Asientos seleccionados: " + contador;
        }


        async void consuta1()
        {
            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 1 : 1);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();

            if (seat.Models[0].busy)
            {
                btn1.IsEnabled = false;
                btn1.BackgroundColor = Color.LightBlue;
                btn1.TextColor = Color.Black;
            }
            else
            {
                btn1.IsEnabled = true;
            }

        }

        async void consuta2()
        {

            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 2 : 2);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();

            if (seat.Models[0].busy)
            {
                btn2.IsEnabled = false;
                btn2.BackgroundColor = Color.LightBlue;
                btn2.TextColor = Color.Black;
            }
            else
            {
                btn2.IsEnabled = true;
            }

        }

        async void consuta3()
        {

            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 3 : 3);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();

            

            if (seat.Models[0].busy)
            {
                btn3.IsEnabled = false;
                btn3.BackgroundColor = Color.LightBlue;
                btn3.TextColor = Color.Black;
            }
            else
            {
                btn3.IsEnabled = true;
            }

        }

        async void consuta4()
        {
            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 4 : 4);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();

            

            if (seat.Models[0].busy)
            {
                btn4.IsEnabled = false;
                btn4.BackgroundColor = Color.LightBlue;
                btn4.TextColor = Color.Black;
            }
            else
            {
                btn4.IsEnabled = true;
            }

        }

        async void consuta5()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 5 : 5);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn5.IsEnabled = false;
                btn5.BackgroundColor = Color.LightBlue;
                btn5.TextColor = Color.Black;
            }
            else
            {
                btn5.IsEnabled = true;
            }

        }

        async void consuta6()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 6 : 6);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn6.IsEnabled = false;
                btn6.BackgroundColor = Color.LightBlue;
                btn6.TextColor = Color.Black;
            }
            else
            {
                btn6.IsEnabled = true;
            }

        }

        async void consuta7()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 7 : 7);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn7.IsEnabled = false;
                btn7.BackgroundColor = Color.LightBlue;
                btn7.TextColor = Color.Black;
            }
            else
            {
                btn7.IsEnabled = true;
            }

        }

        async void consuta8()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 8 : 8);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn8.IsEnabled = false;
                btn8.BackgroundColor = Color.LightBlue;
                btn8.TextColor = Color.Black;
            }
            else
            {
                btn8.IsEnabled = true;
            }

        }
        async void consuta9()
        {
            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 9 : 9);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();

            

            if (seat.Models[0].busy)
            {
                btn9.IsEnabled = false;
                btn9.BackgroundColor = Color.LightBlue;
                btn9.TextColor = Color.Black;
            }
            else
            {
                btn9.IsEnabled = true;
            }
        }

        async void consuta10()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 10 : 10);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn10.IsEnabled = false;
                btn10.BackgroundColor = Color.LightBlue;
                btn10.TextColor = Color.Black;
            }
            else
            {
                btn10.IsEnabled = true;
            }

        }

        async void consuta11()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 11 : 11);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn11.IsEnabled = false;
                btn11.BackgroundColor = Color.LightBlue;
                btn11.TextColor = Color.Black;
            }
            else
            {
                btn11.IsEnabled = true;
            }

        }

        async void consuta12()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 12 : 12);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn12.IsEnabled = false;
                btn12.BackgroundColor = Color.LightBlue;
                btn12.TextColor = Color.Black;
            }
            else
            {
                btn12.IsEnabled = true;
            }

        }

        async void consuta13()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 13 : 13);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn13.IsEnabled = false;
                btn13.BackgroundColor = Color.LightBlue;
                btn13.TextColor = Color.Black;
            }
            else
            {
                btn13.IsEnabled = true;
            }

        }

        async void consuta14()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 14 : 14);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn14.IsEnabled = false;
                btn14.BackgroundColor = Color.LightBlue;
                btn14.TextColor = Color.Black;
            }
            else
            {
                btn14.IsEnabled = true;
            }

        }

        async void consuta15()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 15 : 15);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn15.IsEnabled = false;
                btn15.BackgroundColor = Color.LightBlue;
                btn15.TextColor = Color.Black;
            }
            else
            {
                btn15.IsEnabled = true;
            }

        }

        async void consuta16()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 16 : 16);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn16.IsEnabled = false;
                btn16.BackgroundColor = Color.LightBlue;
                btn16.TextColor = Color.Black;
            }
            else
            {
                btn16.IsEnabled = true;
            }

        }

        async void consuta17()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 17 : 17);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn17.IsEnabled = false;
                btn17.BackgroundColor = Color.LightBlue;
                btn17.TextColor = Color.Black;
            }
            else
            {
                btn17.IsEnabled = true;
            }

        }

        async void consuta18()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 18 : 18);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn18.IsEnabled = false;
                btn18.BackgroundColor = Color.LightBlue;
                btn18.TextColor = Color.Black;
            }
            else
            {
                btn18.IsEnabled = true;
            }

        }
        async void consuta19()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 19 : 19);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn19.IsEnabled = false;
                btn19.BackgroundColor = Color.LightBlue;
                btn19.TextColor = Color.Black;
            }
            else
            {
                btn19.IsEnabled = true;
            }

        }

        async void consuta20()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 20 : 20);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn20.IsEnabled = false;
                btn20.BackgroundColor = Color.LightBlue;
                btn20.TextColor = Color.Black;
            }
            else
            {
                btn20.IsEnabled = true;
            }

        }

        async void consuta21()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 21 : 21);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn21.IsEnabled = false;
                btn21.BackgroundColor = Color.LightBlue;
                btn21.TextColor = Color.Black;
            }
            else
            {
                btn21.IsEnabled = true;
            }

        }

        async void consuta22()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 22 : 22);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn22.IsEnabled = false;
                btn22.BackgroundColor = Color.LightBlue;
                btn22.TextColor = Color.Black;
            }
            else
            {
                btn22.IsEnabled = true;
            }

        }

        async void consuta23()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 23 : 23);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn23.IsEnabled = false;
                btn23.BackgroundColor = Color.LightBlue;
                btn23.TextColor = Color.Black;
            }
            else
            {
                btn23.IsEnabled = true;
            }

        }

        async void consuta24()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 24 : 24);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn24.IsEnabled = false;
                btn24.BackgroundColor = Color.LightBlue;
                btn24.TextColor = Color.Black;
            }
            else
            {
                btn24.IsEnabled = true;
            }

        }

        async void consuta25()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 25 : 25);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn25.IsEnabled = false;
                btn25.BackgroundColor = Color.LightBlue;
                btn25.TextColor = Color.Black;
            }
            else
            {
                btn25.IsEnabled = true;
            }

        }

        async void consuta26()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 26 : 26);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn26.IsEnabled = false;
                btn26.BackgroundColor = Color.LightBlue;
                btn26.TextColor = Color.Black;
            }
            else
            {
                btn26.IsEnabled = true;
            }

        }

        async void consuta27()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 27 : 27);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn27.IsEnabled = false;
                btn27.BackgroundColor = Color.LightBlue;
                btn27.TextColor = Color.Black;
            }
            else
            {
                btn27.IsEnabled = true;
            }

        }

        async void consuta28()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 28 : 28);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn28.IsEnabled = false;
                btn28.BackgroundColor = Color.LightBlue;
                btn28.TextColor = Color.Black;
            }
            else
            {
                btn28.IsEnabled = true;
            }

        }
        async void consuta29()
        {
            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 29 : 29);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn29.IsEnabled = false;
                btn29.BackgroundColor = Color.LightBlue;
                btn29.TextColor = Color.Black;
            }
            else
            {
                btn29.IsEnabled = true;
            }

        }

        async void consuta30()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 30 : 30);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn30.IsEnabled = false;
                btn30.BackgroundColor = Color.LightBlue;
                btn30.TextColor = Color.Black;
            }
            else
            {
                btn30.IsEnabled = true;
            }

        }

        async void consuta31()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 31 : 31);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn31.IsEnabled = false;
                btn31.BackgroundColor = Color.LightBlue;
                btn31.TextColor = Color.Black;
            }
            else
            {
                btn31.IsEnabled = true;
            }

        }

        async void consuta32()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 32 : 32);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn32.IsEnabled = false;
                btn32.BackgroundColor = Color.LightBlue;
                btn32.TextColor = Color.Black;
            }
            else
            {
                btn32.IsEnabled = true;
            }

        }

        async void consuta33()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 33 : 33);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn33.IsEnabled = false;
                btn33.BackgroundColor = Color.LightBlue;
                btn33.TextColor = Color.Black;
            }
            else
            {
                btn33.IsEnabled = true;
            }

        }

        async void consuta34()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 34 : 34);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn34.IsEnabled = false;
                btn34.BackgroundColor = Color.LightBlue;
                btn34.TextColor = Color.Black;
            }
            else
            {
                btn34.IsEnabled = true;
            }

        }

        async void consuta35()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 35 : 35);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn35.IsEnabled = false;
                btn35.BackgroundColor = Color.LightBlue;
                btn35.TextColor = Color.Black;
            }
            else
            {
                btn35.IsEnabled = true;
            }

        }

        async void consuta36()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 36 : 36);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn36.IsEnabled = false;
                btn36.BackgroundColor = Color.LightBlue;
                btn36.TextColor = Color.Black;
            }
            else
            {
                btn36.IsEnabled = true;
            }

        }

        async void consuta37()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 37 : 37);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn37.IsEnabled = false;
                btn37.BackgroundColor = Color.LightBlue;
                btn37.TextColor = Color.Black;
            }
            else
            {
                btn37.IsEnabled = true;
            }

        }

        async void consuta38()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 38 : 38);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn38.IsEnabled = false;
                btn38.BackgroundColor = Color.LightBlue;
                btn38.TextColor = Color.Black;
            }
            else
            {
                btn38.IsEnabled = true;
            }

        }
        async void consuta39()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 39 : 39);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn39.IsEnabled = false;
                btn39.BackgroundColor = Color.LightBlue;
                btn39.TextColor = Color.Black;
            }
            else
            {
                btn39.IsEnabled = true;
            }

        }

        async void consuta40()
        {


            var seatId = (id__ > 1 ? (40 * (id__ - 1)) + 40 : 40);
            var seat = await App.Supa.From<Seat>().Where(s => s.id == seatId).Get();


            

            if (seat.Models[0].busy)
            {
                btn40.IsEnabled = false;
                btn40.BackgroundColor = Color.LightBlue;
                btn40.TextColor = Color.Black;
            }
            else
            {
                btn40.IsEnabled = true;
            }

        }





        async private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (contador == 0)
                {
                    await DisplayAlert("Error", "Debe seleccionar una silla minimo", "ok");
                }
                else
                {
                    int[] a;
                    a = new int[40];
                    a[0] = cbtn1;
                    a[1] = cbtn2;
                    a[2] = cbtn3;
                    a[3] = cbtn4;
                    a[4] = cbtn5;
                    a[5] = cbtn6;
                    a[6] = cbtn7;
                    a[7] = cbtn8;
                    a[8] = cbtn9;
                    a[9] = cbtn10;
                    a[10] = cbtn11;
                    a[11] = cbtn12;
                    a[12] = cbtn13;
                    a[13] = cbtn14;
                    a[14] = cbtn15;
                    a[15] = cbtn16;
                    a[16] = cbtn17;
                    a[17] = cbtn18;
                    a[18] = cbtn19;
                    a[19] = cbtn20;
                    a[20] = cbtn21;
                    a[21] = cbtn22;
                    a[22] = cbtn23;
                    a[23] = cbtn24;
                    a[24] = cbtn25;
                    a[25] = cbtn26;
                    a[26] = cbtn27;
                    a[27] = cbtn28;
                    a[28] = cbtn29;
                    a[29] = cbtn30;
                    a[30] = cbtn31;
                    a[31] = cbtn32;
                    a[32] = cbtn33;
                    a[33] = cbtn34;
                    a[34] = cbtn35;
                    a[35] = cbtn36;
                    a[36] = cbtn37;
                    a[37] = cbtn38;
                    a[38] = cbtn39;
                    a[39] = cbtn40;

                    for (int i = 0; i < 40; i++)
                    {
                        if (a[i] == 1)
                        {
                            a[i] = i + 1;
                        }
                    }

                    var pagina = new pagarEntrada(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__, a);
                    await Navigation.PushAsync(pagina);
                }

            }
            catch (Exception ex) { }
        }


        async private void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}