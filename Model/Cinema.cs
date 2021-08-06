using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFFinalProject.Model
{
    public class Cinema
    {

        public List<CheckBox> seat { get; set; }


        private int place = 1;
        private const int size = 16;
        private const int space = 2;

        public Cinema()
        {
            seat = new List<CheckBox>();
        }

        public void DrawCinema(Canvas MyCanvas)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    CheckBox checbox = new CheckBox();             
                    checbox.Background = Brushes.Green;
                    checbox.Click += new RoutedEventHandler(this.GetPlace_Click);
                    checbox.Name = "c"+place.ToString();
                    MyCanvas.Children.Add(checbox);
                    seat.Add(checbox);           
                    Canvas.SetLeft(checbox, i * (size + space));
                    Canvas.SetTop(checbox, j * (size + space));
                    place++;
                }
            }
        }

        private void GetPlace_Click(object sender, RoutedEventArgs e)
        {

            if ((sender as CheckBox).IsChecked == true)
            {

                (sender as CheckBox).Background = Brushes.Red;
          
               
            }
            else if ((sender as CheckBox).IsChecked == false)
            {

                (sender as CheckBox).Background = Brushes.Green;
            }

        }
    }

}

