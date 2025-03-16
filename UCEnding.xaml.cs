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

namespace Drinks_Machine
{
    /// <summary>
    /// Interaction logic for UCEnding.xaml
    /// </summary>
    public partial class UCEnding : UserControl
    {
        public UCEnding(string Name, string Image, ObservableCollection<Ingredients> DrinkIngredients)
        {
            InitializeComponent();
            lblEnjoy.Content = $"Enjoy your {Name}.";
            BitmapImage bitmap = new BitmapImage(new Uri(Image, UriKind.Relative));
            ImFinalDrink.Source = bitmap;
            LbIngredients.ItemsSource = DrinkIngredients;
            DataContext = this;
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow MainWindow)
            {
                MainWindow.Close();
            }
        }

        private void BtnAnother_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow MainWindow)
            {
                MainWindow.MainContent.Content = new UCSelection(MainWindow);
            }
        }
    }
}
