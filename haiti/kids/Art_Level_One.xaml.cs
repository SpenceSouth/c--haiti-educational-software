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
using haiti;

namespace haiti.kids
{
    /// <summary>
    /// Interaction logic for Art_Level_One.xaml
    /// </summary>
    public partial class Art_Level_One : Page
    {
       /* public Art_Level_One()
        {
            InitializeComponent();

            MessageBox.Show("Currently No Content Available");
        } fixed but this took forever to find :(*/

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
        private void Category_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Name;
            string title = "";
            string prompt = "";

            switch (name)
            {
                case "button0":
                    title = "Description";
                    prompt = "Hundreds of pages of images to color.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Program.runKeaColor();
                    }
                    break;
                case "button4":
                    title = "Description";
                    prompt = "Blank screen on which student may draw using computer.\nWould you like to start this activity?";
                    var dr4 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr4 == MessageBoxResult.Yes)
                    {
                        Program.runDrawForChild();
                    }
                    break;
                case "button12":
                    title = "Instructions";
                    prompt = "Presents pictures of cars, jeeps, racing cars, fancy cars, etc. and lets students paint the cars and observe how they look in various colors and more.\nWould you like to start this activity?";
                    var dr12 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr12 == MessageBoxResult.Yes)
                    {
                        Program.runCarsColor();
                    }
                    break;
                
                default:
                    return;
            }

        }

    }
}
