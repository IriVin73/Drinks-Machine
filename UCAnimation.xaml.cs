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
using System.Speech.Synthesis;
using System.Collections.ObjectModel;

namespace Drinks_Machine
{
    /// <summary>
    /// Interaction logic for UCAnimation.xaml
    /// </summary>
    public partial class UCAnimation : UserControl
    {
        private static Recipe Drink;
        public UCAnimation(Recipe recipe)
        {
            InitializeComponent();
            Drink = recipe;
            StartAnimation();
            ProgressBar.Maximum = Drink.GetSteps().Length;
        }

        private int CurrentStep = 0;

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentStep < Drink.GetSteps().Length-1) 
            {
                CurrentStep++;
                BtnBefore.Visibility = Visibility.Visible;
                ProgressBar.Value++;
                StartAnimation();
                if (CurrentStep == Drink.GetSteps().Length-1)
                {
                    BtnNext.Visibility = Visibility.Collapsed;
                    BtnDone.Visibility = Visibility.Visible;
                }
            }
        }

        private void StartAnimation()
        {
            string ImagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Drink.GetImages()[CurrentStep].ToString());
            LblStep.Content = Drink.GetSteps()[CurrentStep];
            BitmapImage bitmap = new BitmapImage(new Uri(ImagePath, UriKind.Absolute));
            Image.Source = bitmap;

        }

        private void BtnSpeaker_Click(object sender, RoutedEventArgs e)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(LblStep.Content.ToString());
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Ingredients> DrinkIngredients;
            if (Drink.GetName() == "lemon tea")
            {
                DrinkIngredients = new ObservableCollection<Ingredients>
                {
                    new Ingredients ("water", "water.png"),
                    new Ingredients ("tea bag", "tea bag.png"),
                    new Ingredients ("lemon", "full lemon.png")
                };
                UCEnding Ending = new UCEnding("lemon tea", "lemon-tea.png", DrinkIngredients);
                if (Window.GetWindow(this) is MainWindow MainWindow)
                {
                    MainWindow.MainContent.Content = Ending;
                }
            }
            else if (Drink.GetName() == "coffee")
            {
                DrinkIngredients = new ObservableCollection<Ingredients>
                {
                    new Ingredients ("water", "water.png"),
                    new Ingredients ("coffee grounds", "beans.png"),
                    new Ingredients ("sugar", "sugar.png"),
                    new Ingredients ("milk", "milk.png")
                };
                UCEnding Ending = new UCEnding("coffee", "coffee.png", DrinkIngredients);
                if (Window.GetWindow(this) is MainWindow MainWindow)
                {
                    MainWindow.MainContent.Content = Ending;
                }
            }
            else if (Drink.GetName() == "hot chocolate")
            {
                DrinkIngredients = new ObservableCollection<Ingredients>
                {
                    new Ingredients ("water", "water.png"),
                    new Ingredients ("cocoa powder", "cocoa.png")
                };
                UCEnding Ending = new UCEnding("hot chocolate", "hot-chocolate (1).png", DrinkIngredients);
                if (Window.GetWindow(this) is MainWindow MainWindow)
                {
                    MainWindow.MainContent.Content = Ending;
                }
            }

        }

        private void BtnBefore_Click(object sender, RoutedEventArgs e)
        {
            BtnDone.Visibility = Visibility.Collapsed;
            BtnNext.Visibility = Visibility.Visible;
            if (CurrentStep <= Drink.GetSteps().Length - 1)
            {
                CurrentStep--;
                ProgressBar.Value--;
                StartAnimation();
                if (CurrentStep == 0)
                {
                    BtnBefore.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
