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
        Label Esmaspäev, Teisipäev, Kolmapäev, Neljapäev, Rede, Venekeel, VõrgutjaSeadmet, MobRak, TranspLogJuht, Ing, Eestikeel, WpaigSead, TranspLogJuht1, KeemiaBioloogia, WpaigSead1, VõrgutjaSeadmet1, Ing1, KeemiaBioloogia1, MobRak1;
        public TimeTable2() 
        {
            Grid grid = new Grid();
            for (int i = 0; i < 10; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.White;
            }
            Esmaspäev = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.White, Text = "Esmaspäev", FontSize = 15 };
            grid.Children.Add(Esmaspäev, 0, 1);
            Grid.SetColumnSpan(Esmaspäev, 2);

            Teisipäev = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.White, Text = "Teisipäev", FontSize = 15 };
            grid.Children.Add(Teisipäev, 0, 2);
            Grid.SetColumnSpan(Teisipäev, 2);

            Neljapäev = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.White, Text = "Kolmapäev", FontSize = 15 };
            grid.Children.Add(Neljapäev, 0, 3);
            Grid.SetColumnSpan(Neljapäev, 2);

            Kolmapäev = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.White, Text = "Neljapäev", FontSize = 15 };
            grid.Children.Add(Neljapäev, 0, 4);
            Grid.SetColumnSpan(Neljapäev, 2);

            Rede = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.White, Text = "Rede", FontSize = 15 };
            grid.Children.Add(Rede, 0, 5);
            Grid.SetColumnSpan(Rede, 2);

            Venekeel = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGreen, Text = "Keel ja kirendus", FontSize = 15 };
            grid.Children.Add(Venekeel, 2, 1);
            Grid.SetColumnSpan(Venekeel, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) =>

            VõrgutjaSeadmet = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "Võrgut ja seadmete", FontSize = 15 };
            grid.Children.Add(VõrgutjaSeadmet, 4, 1);
            Grid.SetColumnSpan(VõrgutjaSeadmet, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += (s, e) =>

            MobRak = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSkyBlue, Text = "Mob.rak.", FontSize = 15 };
            grid.Children.Add(MobRak, 7, 1);
            Grid.SetColumnSpan(MobRak, 3);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += (s, e) =>

            TranspLogJuht = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Transp.log.junit", FontSize = 15 };
            grid.Children.Add(TranspLogJuht, 2, 2);
            Grid.SetColumnSpan(TranspLogJuht, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += (s, e) =>

            Ing = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Ing(windows hald)", FontSize = 15 };
            grid.Children.Add(Ing, 6, 2);
            Grid.SetColumnSpan(Ing, 2);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += (s, e) =>

            Eestikeel = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Eesti keel teise keelena", FontSize = 15 };
            grid.Children.Add(Eestikeel, 8, 2);
            Grid.SetColumnSpan(Eestikeel, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += (s, e) =>

            WpaigSead = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "W.paig.sead.", FontSize = 15 };
            grid.Children.Add(WpaigSead, 2, 3);
            Grid.SetColumnSpan(WpaigSead, 3);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += (s, e) =>

            TranspLogJuht1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Transp.log.junit", FontSize = 15 };
            grid.Children.Add(TranspLogJuht1, 5, 3);
            Grid.SetColumnSpan(TranspLogJuht1, 5);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += (s, e) =>

            KeemiaBioloogia = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Keemia, bioologia eesti keeles", FontSize = 15 };
            grid.Children.Add(KeemiaBioloogia, 10, 3);
            Grid.SetColumnSpan(KeemiaBioloogia, 1);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += (s, e) =>

            WpaigSead1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "W.paig.sead.", FontSize = 15 };
            grid.Children.Add(WpaigSead1, 2, 4);
            Grid.SetColumnSpan(WpaigSead1, 3);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += (s, e) =>

            VõrgutjaSeadmet1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "Võrgut ja seadmete", FontSize = 15 };
            grid.Children.Add(VõrgutjaSeadmet1, 6, 4);
            Grid.SetColumnSpan(VõrgutjaSeadmet1, 2);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += (s, e) =>

            Ing1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Ing(windows hald)", FontSize = 15 };
            grid.Children.Add(Ing1, 8, 4);
            Grid.SetColumnSpan(Ing1, 2);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += (s, e) =>

            KeemiaBioloogia1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Keemia, bioologia eesti keeles", FontSize = 15 };
            grid.Children.Add(KeemiaBioloogia1, 2, 5);
            Grid.SetColumnSpan(KeemiaBioloogia1, 1);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += (s, e) =>

            MobRak1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSkyBlue, Text = "Mob.rak.", FontSize = 15 };
            grid.Children.Add(MobRak1, 4, 5);
            Grid.SetColumnSpan(MobRak1, 3);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += (s, e) =>

            Venekeel.GestureRecognizers.Add(tap);
            VõrgutjaSeadmet.GestureRecognizers.Add(tap1);
            MobRak.GestureRecognizers.Add(tap2);
            TranspLogJuht.GestureRecognizers.Add(tap3);
            Ing.GestureRecognizers.Add(tap4);
            Eestikeel.GestureRecognizers.Add(tap5);
            WpaigSead.GestureRecognizers.Add(tap6);
            TranspLogJuht1.GestureRecognizers.Add(tap7);
            KeemiaBioloogia.GestureRecognizers.Add(tap8);
            WpaigSead1.GestureRecognizers.Add(tap9);
            VõrgutjaSeadmet1.GestureRecognizers.Add(tap10);
            Ing1.GestureRecognizers.Add(tap11);
            KeemiaBioloogia1.GestureRecognizers.Add(tap12);
            MobRak1.GestureRecognizers.Add(tap13);
            Content = grid;
        }
        public async void MoreInfo()
        {
            await DisplayAlert("Detailed Information", "B221, Mihajlova Ljudmila", "Close");
        }
        public async void MoreInfo1()
        {
            await DisplayAlert("Detailed Information", "A123, Agapov Mikhail", "Close");
        }
        public async void MoreInfo2()
        {
            await DisplayAlert("Detailed Information", "E07, Olenik Marina", "Close");
        }
        public async void MoreInfo3()
        {
            await DisplayAlert("Detailed Information", "B002, Krull Jaanus", "Close");
        }
        public async void MoreInfo4()
        {
            await DisplayAlert("Detailed Information", "B242, Voronetsakaja Jullia", "Close");
        }
        public async void MoreInfo5()
        {
            await DisplayAlert("Detailed Information", "B242, Laanevali-Tots Alina", "Close");
        }
        public async void MoreInfo6()
        {
            await DisplayAlert("Detailed Information", "A243, Shkarbanova Lury", "Close");
        }
        public async void MoreInfo7()
        {
            await DisplayAlert("Detailed Information", "B003, Krull Jaanus", "Close");
        }
        public async void MoreInfo8()
        {
            await DisplayAlert("Detailed Information", "B144, Pesetskaja Svetlana", "Close");
        }
        public async void MoreInfo9()
        {
            await DisplayAlert("Detailed Information", "A243, Shkarbanova Lury", "Close");
        }
        public async void MoreInfo10()
        {
            await DisplayAlert("Detailed Information", "A123, Agapov Mikhail", "Close");
        }
        public async void MoreInfo11()
        {
            await DisplayAlert("Detailed Information", "B242, Voronetsakaja Jullia", "Close");
        }
        public async void MoreInfo12()
        {
            await DisplayAlert("Detailed Information", "B144, Pesetskaja Svetlana", "Close");
        }
        public async void MoreInfo13()
        {
            await DisplayAlert("Detailed Information", "E07, Olenik Marina", "Close");
        }
    }
}

