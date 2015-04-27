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
    /// Interaction logic for Storybooks_Level_Two.xaml
    /// </summary>
    public partial class Storybooks_Level_Two : Page
    {
        public Storybooks_Level_Two()
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
                case "rainbowButton":
                    Process.Start("kids\\level_2\\Storybooks\\rainbow.pdf");
                    break;
                case "nursey1Button":
                    Process.Start("kids\\level_2\\Storybooks\\nurseryRhymes1.pdf");
                    break;
                case "nursey2Button":
                    Process.Start("kids\\level_2\\Storybooks\\nurseryThymes2.pdf");
                    break;
                case "newToyButton":
                    Process.Start("kids\\level_2\\Storybooks\\childrensTheNewToy.pdf");
                    break;
                case "pigsButton":
                    Process.Start("kids\\level_2\\Storybooks\\threeLittlePigs.pdf");
                    break;
                case "airplaneButton":
                    Process.Start("kids\\level_2\\Storybooks\\If I Could Fly an Airplane - travel book.doc");
                    break;               
                default:
                    break;
            }
        }

       
    }
}
