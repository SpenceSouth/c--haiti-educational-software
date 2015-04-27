using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace haiti.kids
{
    /// <summary>
    /// Interaction logic for Rhymes_Level_One.xaml
    /// </summary>
    public partial class Rhymes_Level_One : Page
    {
        public Rhymes_Level_One()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Content;

            switch (name)
            {
                case "Home":
                    Uri homeUri = new Uri("HomePage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(homeUri);
                    break;
                case "About":
                    Uri aboutUri = new Uri("AboutPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(aboutUri);
                    break;
                case "Kids":
                    Uri programsUri = new Uri("KidsPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(programsUri);
                    break;
                case "Teens":
                    Uri teensUri = new Uri("TeensPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(teensUri);
                    break;
                case "Teachers":
                    Uri teachersUri = new Uri("TeachersPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(teachersUri);
                    break;
            }

        }

        private void Program_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Name;

            switch (name)
            {
                case "alphabetButton":
                    Process.Start("kids\\level_1\\Rhymes\\alphabet.mp3");
                    break;
                case "bingoButton":
                    Process.Start("kids\\level_1\\Rhymes\\bingo.mp3");
                    break;
                case "happyButton":
                    Process.Start("kids\\level_1\\Rhymes\\ifyourehappy.mp3");
                    break;
                case "spiderButton":
                    Process.Start("kids\\level_1\\Rhymes\\itsybitsyspider.mp3");
                    break;
                case "oldMacdonaldButton":
                    Process.Start("kids\\level_1\\Rhymes\\oldmacdonald.mp3");
                    break;
                case "buckleShoeButton":
                    Process.Start("kids\\level_1\\Rhymes\\onetwobucklemyshoe.mp3");
                    break;
                case "countingButton":
                    Process.Start("kids\\level_1\\Rhymes\\onetwothreefourfive.mp3");
                    break;
                case "rainButton":
                    Process.Start("kids\\level_1\\Rhymes\\rainraingoaway.mp3");
                    break;
                case "rosieButton":
                    Process.Start("kids\\level_1\\Rhymes\\ringaroundtherosie.mp3");
                    break;
                case "twinkleTwinkleButton":
                    Process.Start("kids\\level_1\\Rhymes\\twinkletwinkle.mp3");
                    break;
                default:
                    break;
            }
        }

       
    }
}
