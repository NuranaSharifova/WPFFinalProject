using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFinalProject.MyControl
{
    /// <summary>
    /// Interaction logic for Star.xaml
    /// </summary>
    public partial class Star : UserControl
    {
       
        public Star()
        {
            InitializeComponent();
          

        }
        private void T1_Click(object sender, RoutedEventArgs e)
        {
            (sender as ToggleButton).IsChecked = true;
        }
    }
}
