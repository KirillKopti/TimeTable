using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTable
{
    public partial class TimeTable2 : ContentPage
    {
        Label Tund1, Tund2, Tund3, Tund4, Tund5, Tund6, Tund7, Tund8, Esmaspaev, Teisipaev, Kolmapaev, Neljapaev, Reede, urok1, urok2, urok3, urok4, urok5, urok6, urok7, urok8, urok9, urok10, urok11, urok12, urok13, urok14;


        
        public TimeTable2()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 6; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition
                { Height = new GridLength(5, GridUnitType.Star) });
            }
            for (int j = 0; j < 3; j++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition
                { Width = new GridLength(1, GridUnitType.Star) });
            }
            Tund1 = new Label { BackgroundColor = Color.White, Text = "\n \n 1" };
            abs.Children.Add(Tund1, 1, 0);
            Tund2 = new Label { BackgroundColor = Color.White, Text = "\n \n 2" };
            abs.Children.Add(Tund2, 2, 0);
            Tund3 = new Label { BackgroundColor = Color.White, Text = "\n \n 3" };
            abs.Children.Add(Tund3, 3, 0);
            Tund4 = new Label { BackgroundColor = Color.White, Text = "\n \n 4" };
            abs.Children.Add(Tund4, 4, 0);
            Tund5 = new Label { BackgroundColor = Color.White, Text = "\n \n 5" };
            abs.Children.Add(Tund5, 5, 0);
            Tund6 = new Label { BackgroundColor = Color.White, Text = "\n \n 6" };
            abs.Children.Add(Tund6, 6, 0);
            Tund7 = new Label { BackgroundColor = Color.White, Text = "\n \n 7" };
            abs.Children.Add(Tund7, 7, 0);
            Tund8 = new Label { BackgroundColor = Color.White, Text = "\n \n 8" };
            abs.Children.Add(Tund8, 8, 0);
            Esmaspaev = new Label { BackgroundColor = Color.White, Text = "\n \n Esmaspäev" };
            abs.Children.Add(Esmaspaev, 0, 1);
            Teisipaev = new Label { BackgroundColor = Color.White, Text = "\n \n Teisipäev" };
            abs.Children.Add(Teisipaev, 0, 2);
            Kolmapaev = new Label { BackgroundColor = Color.White, Text = "\n \n Kolmapäev" };
            abs.Children.Add(Kolmapaev, 0, 3);
            Neljapaev = new Label { BackgroundColor = Color.White, Text = "\n \n Neljapäev" };
            abs.Children.Add(Neljapaev, 0, 4);
            Reede = new Label { BackgroundColor = Color.White, Text = "\n \n Reede" };
            abs.Children.Add(Reede, 0, 5);
            urok1 = new Label { BackgroundColor = Color.LightGreen, Text = "Keel ja \n Kirjandus" };
            abs.Children.Add(urok1, 1, 1);
            Grid.SetColumnSpan(urok1, 2);
            urok2 = new Label { BackgroundColor = Color.Beige, Text = "Võrgud ja Seadm." };
            abs.Children.Add(urok2, 3, 1);
            Grid.SetColumnSpan(urok2, 3);
            urok3 = new Label { BackgroundColor = Color.DeepSkyBlue, Text = "Mob.rak" };
            abs.Children.Add(urok3, 7, 1);
            Grid.SetColumnSpan(urok3, 3);
            urok4 = new Label { BackgroundColor = Color.LightSeaGreen, Text = "Transp.log.hut" };
            abs.Children.Add(urok4, 1, 2);
            Grid.SetColumnSpan(urok4, 3);
            urok5 = new Label { BackgroundColor = Color.Gray, Text = "Ing (windows hald)" };
            abs.Children.Add(urok5, 5, 2);
            Grid.SetColumnSpan(urok5, 2);
            urok6 = new Label { BackgroundColor = Color.Pink, Text = "Eesti keel \n teise kellena" };
            abs.Children.Add(urok6, 7, 2);
            Grid.SetColumnSpan(urok6, 2);
            urok7 = new Label { BackgroundColor = Color.Violet, Text = "W.paig.sead" };
            abs.Children.Add(urok7, 1, 3);
            Grid.SetColumnSpan(urok7, 3);
            urok8 = new Label { BackgroundColor = Color.LightSeaGreen, Text = "Transp.log.hut" };
            abs.Children.Add(urok8, 4, 3);
            Grid.SetColumnSpan(urok8, 5);
            urok9 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia \n Biologia" };
            abs.Children.Add(urok9, 9, 3);
            urok10 = new Label { BackgroundColor = Color.Violet, Text = "W.paig.sead" };
            abs.Children.Add(urok10, 1, 4);
            Grid.SetColumnSpan(urok10, 3);
            urok11 = new Label { BackgroundColor = Color.Beige, Text = "Võrgud ja Seadm" };
            abs.Children.Add(urok11, 5, 4);
            Grid.SetColumnSpan(urok11, 2);
            urok12 = new Label { BackgroundColor = Color.Gray, Text = "Ing (windows hald)" };
            abs.Children.Add(urok12, 7, 4);
            Grid.SetColumnSpan(urok12, 2);
            urok13 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia \n Bioloogia" };
            abs.Children.Add(urok13, 1, 5);
            urok14 = new Label { BackgroundColor = Color.DeepSkyBlue, Text = "Mob.rak" };
            abs.Children.Add(urok14, 3, 5);
            Grid.SetColumnSpan(urok14, 3);
            Content = abs;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Доп. инфо", " B221 \n Mihhailova Ljudmilla", "Kinni");
            };
            urok1.GestureRecognizers.Add(tap1);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += async (s, e) =>
            {
                urok2 = (Label)s;
                await DisplayAlert("Доп. инфо", " A123 \n Agapov Mikhail", "Kinni");
            };
            urok2.GestureRecognizers.Add(tap2);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += async (s, e) =>
            {
                urok3 = (Label)s;
                await DisplayAlert("Доп. инфо", " E007 \n Oleinik Marina", "Kinni");
            };
            urok3.GestureRecognizers.Add(tap3);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += async (s, e) =>
            {
                urok4 = (Label)s;
                await DisplayAlert("Доп. инфо", " B002 \n Krull Jaanus", "Kinni");
            };
            urok4.GestureRecognizers.Add(tap4);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += async (s, e) =>
            {
                urok5 = (Label)s;
                await DisplayAlert("Доп. инфо", " B242 \n Voronetskaja Julia", "Kinni");
            };
            urok5.GestureRecognizers.Add(tap5);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += async (s, e) =>
            {
                urok6 = (Label)s;
                await DisplayAlert("Доп. инфо", " B236 \n Laaneväli-Toots Alina", "Kinni");
            };
            urok6.GestureRecognizers.Add(tap6);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += async (s, e) =>
            {
                urok7 = (Label)s;
                await DisplayAlert("Доп. инфо", " A243 \n Shkarbanova Lury", "Kinni");
            };
            urok7.GestureRecognizers.Add(tap7);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += async (s, e) =>
            {
                urok8 = (Label)s;
                await DisplayAlert("Доп. инфо", " B002 \n Krull Jaanus", "Kinni");
            };
            urok8.GestureRecognizers.Add(tap8);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += async (s, e) =>
            {
                urok9 = (Label)s;
                await DisplayAlert("Доп. инфо", " B144 \n Pesetskaja Svetlana", "Kinni");
            };
            urok9.GestureRecognizers.Add(tap9);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += async (s, e) =>
            {
                urok10 = (Label)s;
                await DisplayAlert("Доп. инфо", " a243 \n Shkarbanova Lury", "Kinni");
            };
            urok10.GestureRecognizers.Add(tap10);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += async (s, e) =>
            {
                urok11 = (Label)s;
                await DisplayAlert("Доп. инфо", " A123 \n Agapov Mikhail", "Kinni");
            };
            urok11.GestureRecognizers.Add(tap11);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += async (s, e) =>
            {
                urok12 = (Label)s;
                await DisplayAlert("Доп. инфо", " B242 \n Voronetskaja Julia", "Kinni");
            };
            urok12.GestureRecognizers.Add(tap12);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += async (s, e) =>
            {
                urok13 = (Label)s;
                await DisplayAlert("Доп. инфо", " B144 \n Pesetskaja Svetlana", "Kinni");
            };
            urok13.GestureRecognizers.Add(tap13);
            var tap14 = new TapGestureRecognizer();
            tap14.Tapped += async (s, e) =>
            {
                urok14 = (Label)s;
                await DisplayAlert("Доп. инфо", " E007 \n Oleinik Marina", "Kinni");
            };
            urok14.GestureRecognizers.Add(tap14);
        }
    }
}

