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
        BoxView box;
        Label pusto, day0, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, Esmaspäev, Teisipäev, Kolamapäev, Neljapäev, Rede;
        Frame KeeljaKirjandus, VõrgutjaSeadmed, Mobrak, Transportlogjuht, Ingwin, EestiKeel, Wpigesead, KemiaBiologia, Vaheaeg;
        public TimeTable2() 
        {
            Grid grid = new Grid();
            for( int i = 0; i < 4; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (int j = 0; j < 3; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            }


            pusto = new Label { BackgroundColor = Color.MistyRose, Text = "\n", FontSize = 5 };
            grid.Children.Add(pusto, 0, 0);

            day0 = new Label { BackgroundColor = Color.MistyRose, Text = "0\n \n7:40-8:25", FontSize = 5 };
            grid.Children.Add(day0, 1, 0);

            day1 = new Label { BackgroundColor = Color.MistyRose, Text = "1\n \n8:30-9:15", FontSize = 5 };
            grid.Children.Add(day1, 2, 0);

            day2 = new Label { BackgroundColor = Color.MistyRose, Text = "2\n \n9:20-10:05", FontSize = 5 };
            grid.Children.Add(day2, 3, 0);

            day3 = new Label { BackgroundColor = Color.MistyRose, Text = "3\n \n10:10-10:55", FontSize = 5 };
            grid.Children.Add(day3, 4, 0);

            day4 = new Label { BackgroundColor = Color.MistyRose, Text = "4\n \n11:00-11:45", FontSize = 5 };
            grid.Children.Add(day4, 5, 0);

            day5 = new Label { BackgroundColor = Color.MistyRose, Text = "5\n \n11:50-12:35", FontSize = 5 };
            grid.Children.Add(day5, 6, 0);

            day6 = new Label { BackgroundColor = Color.MistyRose, Text = "6\n \n12:40-13:25", FontSize = 5 };
            grid.Children.Add(day6, 7, 0);

            day7 = new Label { BackgroundColor = Color.MistyRose, Text = "7\n \n13:30-14:15", FontSize = 5 };
            grid.Children.Add(day7, 8, 0);

            day8 = new Label { BackgroundColor = Color.MistyRose, Text = "8\n \n14:20-15:05", FontSize = 5 };
            grid.Children.Add(day8, 9, 0);

            day9 = new Label { BackgroundColor = Color.MistyRose, Text = "9\n \n15:10-15:55", FontSize = 5 };
            grid.Children.Add(day9, 10, 0);

            day10 = new Label { BackgroundColor = Color.MistyRose, Text = "10\n \n16:00-16:45", FontSize = 5 };
            grid.Children.Add(day10, 11, 0);

            Esmaspäev = new Label { BackgroundColor = Color.MistyRose, Text = "Esmaspäev\n", FontSize = 5 };
            grid.Children.Add(Esmaspäev, 0, 1);

            Teisipäev = new Label { BackgroundColor = Color.MistyRose, Text = "Teisipäev\n", FontSize = 5 };
            grid.Children.Add(Teisipäev, 0, 2);

            Kolamapäev = new Label { BackgroundColor = Color.MistyRose, Text = "Kolmapäev\n", FontSize = 5 };
            grid.Children.Add(Kolamapäev, 0, 3);

            Neljapäev = new Label { BackgroundColor = Color.MistyRose, Text = "Neljapäev\n", FontSize = 5 };
            grid.Children.Add(Neljapäev, 0, 4);

            Rede = new Label { BackgroundColor = Color.MistyRose, Text = "Rede\n", FontSize = 5 };
            grid.Children.Add(Rede, 0, 5);


            KeeljaKirjandus = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(KeeljaKirjandus, 2, 1);
            Grid.SetColumnSpan(KeeljaKirjandus, 2);
            KeeljaKirjandus = new Frame;

            VõrgutjaSeadme = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(VõrgutjaSeadmed, 3, 1);
            Grid.SetColumnSpan(VõrgutjaSeadmed, 2);
            VõrgutjaSeadmed = new Frame;

            Vaheaeg = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(Vaheaeg, 4, 1);
            Grid.SetColumnSpan(Vaheaeg, 1);
            Vaheaeg = new Frame;

            Mobrak = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(Mobrak, 5, 1);
            Grid.SetColumnSpan(Mobrak, 3);
            Mobrak = new Frame;

             = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(VõrgutjaSeadmed, 3, 1);
            Grid.SetColumnSpan(VõrgutjaSeadmed, 1);
            VõrgutjaSeadmed = new Frame;

            VõrgutjaSeadmed = new Frame { BorderColor = Color.White, BackgroundColor = Color.White };
            grid.Children.Add(VõrgutjaSeadmed, 3, 1);
            Grid.SetColumnSpan(VõrgutjaSeadmed, 1);
            VõrgutjaSeadmed = new Frame;

            {
                BackgroundColor = Color.BlueViolet,
                BorderColor = Color.White,
                CornerRadius = 10,
                Opacity = 0 
            };
            grid.Children.Add(VõrgutjaSeadmed, 2, 3);
            Grid.SetRowSpan(KeeljaKirjandus, 2);
            Content = grid;
        }
    }
}

