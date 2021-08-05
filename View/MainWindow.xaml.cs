using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFFinalProject.Service;
using WPFFinalProject.ViewModel;

namespace WPFFinalProject.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<CheckBox> Checkbox { get; set; }
        public ObservableCollection<Button> Buttons { get; set; }
      
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new CinemaModelView(new JsonFileService()); ;
            Checkbox = new ObservableCollection<CheckBox>() { ch0, ch1, ch2 };
            Buttons= new ObservableCollection<Button>() { b1,b2,b3 };


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            bookWindow.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
     
        }

    }
}
