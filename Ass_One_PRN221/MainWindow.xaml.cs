using System;
using System.Collections.Generic;
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

namespace Ass_One_PRN221
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += dgCarList_Loaded;
        }

        private void dgCarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgCarList_Loaded(object sender, RoutedEventArgs e)
        {
            List<dynamic> cars = new List<dynamic>
            {
                new {CarName = "A6", Color = "White", Brand="Audi"},
                new {CarName = "Lexus", Color = "Black", Brand="Toyota"},
                new {CarName = "Ford Ranger Raptor", Color = "White", Brand="Ford"},
            };
            dgCarList.ItemsSource = cars;

        }
    }
}
