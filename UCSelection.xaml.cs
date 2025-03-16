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

namespace Drinks_Machine
{
    /// <summary>
    /// Interaction logic for UCSelection.xaml
    /// </summary>
    public partial class UCSelection : UserControl
    {
        private MainWindow MainWindow;

        public UCSelection(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        private void btnLemonTea_Click(object sender, RoutedEventArgs e)
        {
            string[] StepsLemonTea =
            {
                "Step 1: Boil some water",
                "Step 2: Steep the water in the tea",
                "Step 3: Pour tea in the cup",
                "Step 4: Add lemon"
            };

            string[] ImagesLemonTea =
            {
                "kettle.gif",
                "tea bag.png",
                "tea cup.gif",
                "lemon.png"
            };

            Recipe LemonTea = new Recipe("lemon tea", StepsLemonTea, ImagesLemonTea);
            MainWindow.MainContent.Content = new UCAnimation(LemonTea);
        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            string[] StepsCoffee =
            {
                "Step 1: Boil some water",
                "Step 2: Brew the coffee grounds",
                "Step 3: Pour coffee in the cup",
                "Step 4: Add sugar and milk"
            };

            string[] ImagesCoffee =
            {
                "kettle.gif",
                "ground coffee.gif",
                "coffee.png",
                "milk and sugar.png"
            };

            Recipe Coffee = new Recipe("coffee", StepsCoffee, ImagesCoffee);
            MainWindow.MainContent.Content = new UCAnimation(Coffee);
        }

        private void btnHotChocolate_Click(object sender, RoutedEventArgs e)
        {
            string[] StepsCocoa =
            {
                "Step 1: Boil some water",
                "Step 2: Add drinking chocolate powder to the water",
                "Step 3: Pour chocolate in the cup"
            };

            string[] ImagesCocoa =
            {
                "pot.png",
                "cocoa.png",
                "pour cocoa.png"
            };

            Recipe HotCocoa = new Recipe("hot chocolate", StepsCocoa, ImagesCocoa);
            MainWindow.MainContent.Content = new UCAnimation(HotCocoa);
        }
    }
        
    
}
