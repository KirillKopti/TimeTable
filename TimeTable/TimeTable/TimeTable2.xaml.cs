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
        Label lbl;
        Frame frm, frm2;
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


            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 1, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 2, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 3, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 4, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 5, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 6, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 7, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 8, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 9, 0);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 1);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 2);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 3);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 4);

            lbl = new Label { BackgroundColor = Color.MistyRose, Text = "Проверка\n", FontSize = 10 };
            grid.Children.Add(lbl, 0, 5);


            frm = new Frame { BorderColor = Color.Black, BackgroundColor = Color.White };
            grid.Children.Add(frm, 1, 2);
            Grid.SetColumnSpan(frm, 3);//объединим 3 ячейки, где находиться рамка frm
            frm2 = new Frame
            {
                BackgroundColor = Color.BlueViolet,
                BorderColor = Color.Red,
                CornerRadius = 10,
                Opacity = 0 
            };
            grid.Children.Add(frm2, 2, 3);
            Grid.SetRowSpan(frm2, 2);
            Content = grid;
        }
    }
}

